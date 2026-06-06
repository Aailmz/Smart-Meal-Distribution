using System;
using System.Windows.Forms;
using LKS2026.Forms;
using LKS2026.Helpers;

namespace LKS2026.UserControls
{
    public partial class UcBahanBaku : UserControl
    {
        public UcBahanBaku()
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
                string sql = @"SELECT MaterialId AS [ID], MaterialName AS [Nama Bahan], Category AS [Kategori],
                                      Unit AS [Satuan], Stock AS [Stok], EstimatedPrice AS [Harga Perkiraan]
                               FROM RawMaterials";
                System.Data.SqlClient.SqlParameter[] p = null;
                if (!string.IsNullOrWhiteSpace(search))
                {
                    sql += " WHERE MaterialName LIKE @q OR Category LIKE @q";
                    p = new[] { Database.P("@q", "%" + search.Trim() + "%") };
                }
                sql += " ORDER BY MaterialId DESC";
                grid.DataSource = Database.Query(sql, p);
                if (grid.Columns.Contains("Harga Perkiraan"))
                    grid.Columns["Harga Perkiraan"].DefaultCellStyle.Format = "N0";
                if (grid.Columns.Contains("Stok"))
                    grid.Columns["Stok"].DefaultCellStyle.Format = "N2";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            using (var f = new FormBahanBakuEdit())
                if (f.ShowDialog() == DialogResult.OK) LoadData(txtCari.Text);
        }

        private void BtnUbah_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow == null) { MessageBox.Show("Pilih bahan baku terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            using (var f = new FormBahanBakuEdit(Convert.ToInt32(grid.CurrentRow.Cells[0].Value)))
                if (f.ShowDialog() == DialogResult.OK) LoadData(txtCari.Text);
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow == null) { MessageBox.Show("Pilih bahan baku terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (MessageBox.Show("Yakin ingin menghapus bahan baku yang dipilih?\nTindakan ini tidak dapat dibatalkan.", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            try
            {
                Database.Execute("DELETE FROM RawMaterials WHERE MaterialId=@i",
                    Database.P("@i", Convert.ToInt32(grid.CurrentRow.Cells[0].Value)));
                LoadData(txtCari.Text);
                MessageBox.Show("Data berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus: " + ex.Message + "\n(Mungkin bahan masih dipakai di kebutuhan/pesanan.)", "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtCari_TextChanged(object sender, EventArgs e) => LoadData(txtCari.Text);
    }
}
