using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using LKS2026.Helpers;

namespace LKS2026.Forms
{
    public partial class FormKebutuhanEdit : Form
    {
        private readonly int? _id;
        public FormKebutuhanEdit() { InitializeComponent(); Text = "Tambah Kebutuhan Dapur"; LoadMaterials(); dtTanggal.Value = DateTime.Today; }
        public FormKebutuhanEdit(int id) : this()
        {
            _id = id;
            Text = "Ubah Kebutuhan Dapur";
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
                cmbBahan.SelectedIndexChanged += CmbBahan_SelectedIndexChanged;
                if (dt.Rows.Count > 0) txtSatuan.Text = dt.Rows[0]["Unit"].ToString();
            }
            catch (Exception ex) { MessageBox.Show("Gagal memuat bahan: " + ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void CmbBahan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBahan.SelectedItem is DataRowView row)
                txtSatuan.Text = row["Unit"].ToString();
        }

        private void LoadEntity()
        {
            try
            {
                var dt = Database.Query("SELECT * FROM KitchenNeeds WHERE NeedId=@i", Database.P("@i", _id));
                if (dt.Rows.Count == 0) { MessageBox.Show("Data tidak ditemukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning); Close(); return; }
                var r = dt.Rows[0];
                dtTanggal.Value = Convert.ToDateTime(r["NeedDate"]);
                cmbBahan.SelectedValue = Convert.ToInt32(r["MaterialId"]);
                txtJumlah.Text = Convert.ToDecimal(r["Quantity"]).ToString(CultureInfo.InvariantCulture);
                txtSatuan.Text = r["Unit"].ToString();
                txtCatatan.Text = r["Notes"]?.ToString();
            }
            catch (Exception ex) { MessageBox.Show("Gagal memuat: " + ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (cmbBahan.SelectedValue == null) { MessageBox.Show("Pilih bahan baku.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (!decimal.TryParse(txtJumlah.Text.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal qty) || qty <= 0)
            { MessageBox.Show("Jumlah harus angka > 0.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            try
            {
                if (_id.HasValue)
                {
                    Database.Execute(@"UPDATE KitchenNeeds SET NeedDate=@d, MaterialId=@m, Quantity=@q, Unit=@u, Notes=@n WHERE NeedId=@i",
                        Database.P("@d", dtTanggal.Value.Date),
                        Database.P("@m", Convert.ToInt32(cmbBahan.SelectedValue)),
                        Database.P("@q", qty),
                        Database.P("@u", txtSatuan.Text.Trim()),
                        Database.P("@n", txtCatatan.Text.Trim()),
                        Database.P("@i", _id.Value));
                }
                else
                {
                    Database.Execute(@"INSERT INTO KitchenNeeds (NeedDate, MaterialId, Quantity, Unit, Notes) VALUES (@d,@m,@q,@u,@n)",
                        Database.P("@d", dtTanggal.Value.Date),
                        Database.P("@m", Convert.ToInt32(cmbBahan.SelectedValue)),
                        Database.P("@q", qty),
                        Database.P("@u", txtSatuan.Text.Trim()),
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
