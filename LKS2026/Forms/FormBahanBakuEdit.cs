using System;
using System.Globalization;
using System.Windows.Forms;
using LKS2026.Helpers;

namespace LKS2026.Forms
{
    public partial class FormBahanBakuEdit : Form
    {
        private readonly int? _id;
        public FormBahanBakuEdit() { InitializeComponent(); Text = "Tambah Bahan Baku"; }
        public FormBahanBakuEdit(int id) : this()
        {
            _id = id;
            Text = "Ubah Bahan Baku";
            LoadEntity();
        }

        private void LoadEntity()
        {
            try
            {
                var dt = Database.Query("SELECT * FROM RawMaterials WHERE MaterialId=@i", Database.P("@i", _id));
                if (dt.Rows.Count == 0) { UiHelper.Warn("Data tidak ditemukan."); Close(); return; }
                var r = dt.Rows[0];
                txtNama.Text = r["MaterialName"].ToString();
                cmbKategori.Text = r["Category"].ToString();
                cmbSatuan.Text = r["Unit"].ToString();
                txtStok.Text = Convert.ToDecimal(r["Stock"]).ToString(CultureInfo.InvariantCulture);
                txtHarga.Text = Convert.ToDecimal(r["EstimatedPrice"]).ToString(CultureInfo.InvariantCulture);
            }
            catch (Exception ex) { UiHelper.Error("Gagal memuat: " + ex.Message); }
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text)) { UiHelper.Warn("Nama bahan wajib diisi."); return; }
            if (!decimal.TryParse(txtStok.Text.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal stok) || stok < 0)
            { UiHelper.Warn("Stok harus angka >= 0."); return; }
            if (!decimal.TryParse(txtHarga.Text.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal harga) || harga < 0)
            { UiHelper.Warn("Harga harus angka >= 0."); return; }

            try
            {
                if (_id.HasValue)
                {
                    Database.Execute(@"UPDATE RawMaterials SET MaterialName=@n, Category=@c, Unit=@u, Stock=@s, EstimatedPrice=@p WHERE MaterialId=@i",
                        Database.P("@n", txtNama.Text.Trim()),
                        Database.P("@c", cmbKategori.Text.Trim()),
                        Database.P("@u", cmbSatuan.Text.Trim()),
                        Database.P("@s", stok),
                        Database.P("@p", harga),
                        Database.P("@i", _id.Value));
                }
                else
                {
                    Database.Execute(@"INSERT INTO RawMaterials (MaterialName, Category, Unit, Stock, EstimatedPrice) VALUES (@n,@c,@u,@s,@p)",
                        Database.P("@n", txtNama.Text.Trim()),
                        Database.P("@c", cmbKategori.Text.Trim()),
                        Database.P("@u", cmbSatuan.Text.Trim()),
                        Database.P("@s", stok),
                        Database.P("@p", harga));
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex) { UiHelper.Error("Gagal menyimpan: " + ex.Message); }
        }

        private void BtnBatal_Click(object sender, EventArgs e) { DialogResult = DialogResult.Cancel; Close(); }
    }
}
