using System;
using System.Windows.Forms;
using LKS2026.Forms;
using LKS2026.Helpers;

namespace LKS2026.UserControls
{
    public partial class UcKebutuhanDapur : UserControl
    {
        public UcKebutuhanDapur()
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
                string sql = @"SELECT k.NeedId AS [ID], k.NeedDate AS [Tanggal], m.MaterialName AS [Bahan],
                                      k.Quantity AS [Jumlah], k.Unit AS [Satuan], k.Notes AS [Keterangan]
                               FROM KitchenNeeds k
                               INNER JOIN RawMaterials m ON k.MaterialId = m.MaterialId";
                System.Data.SqlClient.SqlParameter[] p = null;
                if (!string.IsNullOrWhiteSpace(search))
                {
                    sql += " WHERE m.MaterialName LIKE @q OR CONVERT(VARCHAR, k.NeedDate, 23) LIKE @q";
                    p = new[] { Database.P("@q", "%" + search.Trim() + "%") };
                }
                sql += " ORDER BY k.NeedDate DESC, k.NeedId DESC";
                grid.DataSource = Database.Query(sql, p);
                if (grid.Columns.Contains("Tanggal")) grid.Columns["Tanggal"].DefaultCellStyle.Format = "dd MMM yyyy";
                if (grid.Columns.Contains("Jumlah")) grid.Columns["Jumlah"].DefaultCellStyle.Format = "N2";
            }
            catch (Exception ex) { UiHelper.Error("Gagal memuat: " + ex.Message); }
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            using (var f = new FormKebutuhanEdit())
                if (f.ShowDialog() == DialogResult.OK) LoadData(txtCari.Text);
        }
        private void BtnUbah_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow == null) { UiHelper.Warn("Pilih data kebutuhan terlebih dahulu."); return; }
            using (var f = new FormKebutuhanEdit(Convert.ToInt32(grid.CurrentRow.Cells[0].Value)))
                if (f.ShowDialog() == DialogResult.OK) LoadData(txtCari.Text);
        }
        private void BtnHapus_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow == null) { UiHelper.Warn("Pilih data kebutuhan terlebih dahulu."); return; }
            if (!UiHelper.ConfirmDelete("kebutuhan dapur")) return;
            try
            {
                Database.Execute("DELETE FROM KitchenNeeds WHERE NeedId=@i", Database.P("@i", Convert.ToInt32(grid.CurrentRow.Cells[0].Value)));
                LoadData(txtCari.Text);
                UiHelper.Info("Data berhasil dihapus.");
            }
            catch (Exception ex) { UiHelper.Error("Gagal menghapus: " + ex.Message); }
        }
        private void TxtCari_TextChanged(object sender, EventArgs e) => LoadData(txtCari.Text);
    }
}
