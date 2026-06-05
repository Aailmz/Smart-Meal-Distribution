using System;
using System.Windows.Forms;
using LKS2026.Helpers;

namespace LKS2026.Forms
{
    public partial class FormMonitoringEdit : Form
    {
        private readonly int? _id;
        public FormMonitoringEdit() { InitializeComponent(); Text = "Tambah Produksi/Distribusi"; LoadSchools(); dtTanggal.Value = DateTime.Today; cmbProd.SelectedItem = "Belum Diproses"; cmbDist.SelectedItem = "Belum Dikirim"; }
        public FormMonitoringEdit(int id) : this()
        {
            _id = id;
            Text = "Ubah Produksi/Distribusi";
            LoadEntity();
        }

        private void LoadSchools()
        {
            try
            {
                var dt = Database.Query("SELECT SchoolId, SchoolName FROM Schools ORDER BY SchoolName");
                cmbSekolah.DataSource = dt;
                cmbSekolah.DisplayMember = "SchoolName";
                cmbSekolah.ValueMember = "SchoolId";
            }
            catch (Exception ex) { UiHelper.Error("Gagal memuat sekolah: " + ex.Message); }
        }

        private void LoadEntity()
        {
            try
            {
                var dt = Database.Query("SELECT * FROM ProductionDistribution WHERE ProcessId=@i", Database.P("@i", _id));
                if (dt.Rows.Count == 0) { UiHelper.Warn("Data tidak ditemukan."); Close(); return; }
                var r = dt.Rows[0];
                dtTanggal.Value = Convert.ToDateTime(r["ProcessDate"]);
                cmbSekolah.SelectedValue = Convert.ToInt32(r["SchoolId"]);
                numPorsi.Value = Convert.ToDecimal(r["PortionCount"]);
                cmbProd.SelectedItem = r["ProductionStatus"].ToString();
                cmbDist.SelectedItem = r["DistributionStatus"].ToString();
                txtCatatan.Text = r["Notes"]?.ToString();
            }
            catch (Exception ex) { UiHelper.Error("Gagal memuat: " + ex.Message); }
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (cmbSekolah.SelectedValue == null) { UiHelper.Warn("Pilih sekolah penerima."); return; }

            try
            {
                if (_id.HasValue)
                {
                    Database.Execute(@"UPDATE ProductionDistribution
                                       SET ProcessDate=@d, SchoolId=@s, PortionCount=@p,
                                           ProductionStatus=@ps, DistributionStatus=@ds, Notes=@n
                                       WHERE ProcessId=@i",
                        Database.P("@d", dtTanggal.Value.Date),
                        Database.P("@s", Convert.ToInt32(cmbSekolah.SelectedValue)),
                        Database.P("@p", (int)numPorsi.Value),
                        Database.P("@ps", cmbProd.SelectedItem?.ToString() ?? "Belum Diproses"),
                        Database.P("@ds", cmbDist.SelectedItem?.ToString() ?? "Belum Dikirim"),
                        Database.P("@n", txtCatatan.Text.Trim()),
                        Database.P("@i", _id.Value));
                }
                else
                {
                    Database.Execute(@"INSERT INTO ProductionDistribution
                                       (ProcessDate, SchoolId, PortionCount, ProductionStatus, DistributionStatus, Notes)
                                       VALUES (@d,@s,@p,@ps,@ds,@n)",
                        Database.P("@d", dtTanggal.Value.Date),
                        Database.P("@s", Convert.ToInt32(cmbSekolah.SelectedValue)),
                        Database.P("@p", (int)numPorsi.Value),
                        Database.P("@ps", cmbProd.SelectedItem?.ToString() ?? "Belum Diproses"),
                        Database.P("@ds", cmbDist.SelectedItem?.ToString() ?? "Belum Dikirim"),
                        Database.P("@n", txtCatatan.Text.Trim()));
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex) { UiHelper.Error("Gagal menyimpan: " + ex.Message); }
        }

        private void BtnBatal_Click(object sender, EventArgs e) { DialogResult = DialogResult.Cancel; Close(); }
    }
}
