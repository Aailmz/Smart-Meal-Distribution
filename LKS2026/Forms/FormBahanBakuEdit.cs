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
                if (dt.Rows.Count == 0) { MessageBox.Show("Data tidak ditemukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning); Close(); return; }
                var r = dt.Rows[0];
                txtNama.Text = r["MaterialName"].ToString();
                cmbKategori.Text = r["Category"].ToString();
                cmbSatuan.Text = r["Unit"].ToString();
                txtStok.Text = Convert.ToDecimal(r["Stock"]).ToString(CultureInfo.InvariantCulture);
                txtHarga.Text = Convert.ToDecimal(r["EstimatedPrice"]).ToString(CultureInfo.InvariantCulture);
            }
            catch (Exception ex) { MessageBox.Show("Gagal memuat: " + ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text)) { MessageBox.Show("Nama bahan wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (!decimal.TryParse(txtStok.Text.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal stok) || stok < 0)
            { MessageBox.Show("Stok harus angka >= 0.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (!decimal.TryParse(txtHarga.Text.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal harga) || harga < 0)
            { MessageBox.Show("Harga harus angka >= 0.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

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
            catch (Exception ex) { MessageBox.Show("Gagal menyimpan: " + ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void BtnBatal_Click(object sender, EventArgs e) { DialogResult = DialogResult.Cancel; Close(); }
    }
}
