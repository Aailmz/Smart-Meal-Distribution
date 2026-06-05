using System;
using System.Data;
using System.Windows.Forms;
using LKS2026.Forms;
using LKS2026.Helpers;

namespace LKS2026.UserControls
{
    public partial class UcPegawai : UserControl
    {
        public UcPegawai()
        {
            InitializeComponent();
            LoadData();
            ApplyRoleAccess();
        }

        private void ApplyRoleAccess()
        {
            // Supervisor hanya view
            bool canEdit = Session.IsPetugas;
            btnTambah.Enabled = canEdit;
            btnUbah.Enabled = canEdit;
            btnHapus.Enabled = canEdit;
        }

        private void LoadData(string search = null)
        {
            try
            {
                string sql = @"SELECT EmployeeId AS [ID Pegawai], EmployeeName AS [Nama], Position AS [Jabatan],
                                      Phone AS [No. HP], Address AS [Alamat]
                               FROM Employees";
                System.Data.SqlClient.SqlParameter[] p = null;
                if (!string.IsNullOrWhiteSpace(search))
                {
                    sql += " WHERE EmployeeName LIKE @q OR Position LIKE @q";
                    p = new[] { Database.P("@q", "%" + search.Trim() + "%") };
                }
                sql += " ORDER BY EmployeeId DESC";
                grid.DataSource = Database.Query(sql, p);
            }
            catch (Exception ex)
            {
                UiHelper.Error("Gagal memuat data pegawai: " + ex.Message);
            }
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            using (var f = new FormPegawaiEdit())
            {
                if (f.ShowDialog() == DialogResult.OK) LoadData(txtCari.Text);
            }
        }

        private void BtnUbah_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow == null) { UiHelper.Warn("Pilih data pegawai terlebih dahulu."); return; }
            int id = Convert.ToInt32(grid.CurrentRow.Cells[0].Value);
            using (var f = new FormPegawaiEdit(id))
            {
                if (f.ShowDialog() == DialogResult.OK) LoadData(txtCari.Text);
            }
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow == null) { UiHelper.Warn("Pilih data pegawai terlebih dahulu."); return; }
            if (!UiHelper.ConfirmDelete("pegawai")) return;
            int id = Convert.ToInt32(grid.CurrentRow.Cells[0].Value);
            try
            {
                Database.Execute("DELETE FROM Employees WHERE EmployeeId=@i", Database.P("@i", id));
                LoadData(txtCari.Text);
                UiHelper.Info("Data pegawai berhasil dihapus.");
            }
            catch (Exception ex)
            {
                UiHelper.Error("Gagal menghapus: " + ex.Message);
            }
        }

        private void TxtCari_TextChanged(object sender, EventArgs e) => LoadData(txtCari.Text);
    }
}
