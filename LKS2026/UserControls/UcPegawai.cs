using System;
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
                MessageBox.Show("Gagal memuat data pegawai: " + ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            using (var f = new FormPegawaiEdit())
                if (f.ShowDialog() == DialogResult.OK) LoadData(txtCari.Text);
        }

        private void BtnUbah_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow == null) { MessageBox.Show("Pilih data pegawai terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            using (var f = new FormPegawaiEdit(Convert.ToInt32(grid.CurrentRow.Cells[0].Value)))
                if (f.ShowDialog() == DialogResult.OK) LoadData(txtCari.Text);
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow == null) { MessageBox.Show("Pilih data pegawai terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (MessageBox.Show("Yakin ingin menghapus pegawai yang dipilih?\nTindakan ini tidak dapat dibatalkan.", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            try
            {
                Database.Execute("DELETE FROM Employees WHERE EmployeeId=@i", Database.P("@i", Convert.ToInt32(grid.CurrentRow.Cells[0].Value)));
                LoadData(txtCari.Text);
                MessageBox.Show("Data pegawai berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus: " + ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtCari_TextChanged(object sender, EventArgs e) => LoadData(txtCari.Text);
    }
}
