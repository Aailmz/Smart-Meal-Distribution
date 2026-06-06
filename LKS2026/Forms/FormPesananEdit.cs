using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using LKS2026.Helpers;

namespace LKS2026.Forms
{
    public partial class FormPesananEdit : Form
    {
        private readonly int? _id;
        public FormPesananEdit() { InitializeComponent(); Text = "Tambah Pesanan"; LoadMaterials(); dtTanggal.Value = DateTime.Today; cmbStatus.SelectedItem = "Pending"; }
        public FormPesananEdit(int id) : this()
        {
            _id = id;
            Text = "Ubah Pesanan";
            LoadEntity();
        }

        private void LoadMaterials()
        {
            try
            {
                var dt = Database.Query("SELECT MaterialId, MaterialName, Unit FROM RawMaterials ORDER BY MaterialName");
                cmbBahan.DataSource = dt;
                cmbBahan.DisplayMember = "MaterialName";
                cmbBahan.ValueMember = "MaterialId";
                cmbBahan.SelectedIndexChanged += (s, e) =>
                {
                    if (cmbBahan.SelectedItem is DataRowView row)
                        txtSatuan.Text = row["Unit"].ToString();
                };
                if (dt.Rows.Count > 0) txtSatuan.Text = dt.Rows[0]["Unit"].ToString();
            }
            catch (Exception ex) { MessageBox.Show("Gagal memuat bahan: " + ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void LoadEntity()
        {
            try
            {
                var dt = Database.Query("SELECT * FROM SupplierOrders WHERE OrderId=@i", Database.P("@i", _id));
                if (dt.Rows.Count == 0) { MessageBox.Show("Data tidak ditemukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning); Close(); return; }
                var r = dt.Rows[0];
                dtTanggal.Value = Convert.ToDateTime(r["OrderDate"]);
                txtPemasok.Text = r["SupplierName"].ToString();
                cmbBahan.SelectedValue = Convert.ToInt32(r["MaterialId"]);
                txtJumlah.Text = Convert.ToDecimal(r["OrderQuantity"]).ToString(CultureInfo.InvariantCulture);
                txtSatuan.Text = r["Unit"].ToString();
                cmbStatus.SelectedItem = r["Status"].ToString();
                txtCatatan.Text = r["Notes"]?.ToString();
            }
            catch (Exception ex) { MessageBox.Show("Gagal memuat: " + ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPemasok.Text)) { MessageBox.Show("Nama pemasok wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (cmbBahan.SelectedValue == null) { MessageBox.Show("Pilih bahan baku.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (!decimal.TryParse(txtJumlah.Text.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal qty) || qty <= 0)
            { MessageBox.Show("Jumlah harus angka > 0.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            try
            {
                if (_id.HasValue)
                {
                    Database.Execute(@"UPDATE SupplierOrders
                                       SET OrderDate=@d, SupplierName=@p, MaterialId=@m, OrderQuantity=@q, Unit=@u, Status=@s, Notes=@n
                                       WHERE OrderId=@i",
                        Database.P("@d", dtTanggal.Value.Date),
                        Database.P("@p", txtPemasok.Text.Trim()),
                        Database.P("@m", Convert.ToInt32(cmbBahan.SelectedValue)),
                        Database.P("@q", qty),
                        Database.P("@u", txtSatuan.Text.Trim()),
                        Database.P("@s", cmbStatus.SelectedItem?.ToString() ?? "Pending"),
                        Database.P("@n", txtCatatan.Text.Trim()),
                        Database.P("@i", _id.Value));
                }
                else
                {
                    Database.Execute(@"INSERT INTO SupplierOrders (OrderDate, SupplierName, MaterialId, OrderQuantity, Unit, Status, Notes)
                                       VALUES (@d,@p,@m,@q,@u,@s,@n)",
                        Database.P("@d", dtTanggal.Value.Date),
                        Database.P("@p", txtPemasok.Text.Trim()),
                        Database.P("@m", Convert.ToInt32(cmbBahan.SelectedValue)),
                        Database.P("@q", qty),
                        Database.P("@u", txtSatuan.Text.Trim()),
                        Database.P("@s", cmbStatus.SelectedItem?.ToString() ?? "Pending"),
                        Database.P("@n", txtCatatan.Text.Trim()));
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex) { MessageBox.Show("Gagal menyimpan: " + ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void BtnBatal_Click(object sender, EventArgs e) { DialogResult = DialogResult.Cancel; Close(); }
    }
}
