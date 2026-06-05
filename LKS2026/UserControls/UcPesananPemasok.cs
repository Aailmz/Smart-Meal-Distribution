using System;
using System.Drawing;
using System.Windows.Forms;
using LKS2026.Forms;
using LKS2026.Helpers;

namespace LKS2026.UserControls
{
    public partial class UcPesananPemasok : UserControl
    {
        public UcPesananPemasok()
        {
            InitializeComponent();
            LoadData();
            // Petugas: full CRUD + update status
            // Supervisor: lihat saja + validasi status
            bool isPetugas = Session.IsPetugas;
            btnTambah.Enabled = isPetugas;
            btnUbah.Enabled   = isPetugas;
            btnHapus.Enabled  = isPetugas;
            btnStatus.Enabled = true; // validasi status diizinkan untuk kedua role
        }

        private void LoadData(string search = null)
        {
            try
            {
                string sql = @"SELECT o.OrderId AS [ID], o.OrderDate AS [Tanggal], o.SupplierName AS [Pemasok],
                                      m.MaterialName AS [Bahan], o.OrderQuantity AS [Jumlah], o.Unit AS [Satuan],
                                      o.Status AS [Status], o.Notes AS [Catatan]
                               FROM SupplierOrders o
                               INNER JOIN RawMaterials m ON o.MaterialId = m.MaterialId";
                System.Data.SqlClient.SqlParameter[] p = null;
                if (!string.IsNullOrWhiteSpace(search))
                {
                    sql += " WHERE o.SupplierName LIKE @q OR m.MaterialName LIKE @q OR o.Status LIKE @q";
                    p = new[] { Database.P("@q", "%" + search.Trim() + "%") };
                }
                sql += " ORDER BY o.OrderDate DESC, o.OrderId DESC";
                grid.DataSource = Database.Query(sql, p);
                if (grid.Columns.Contains("Tanggal")) grid.Columns["Tanggal"].DefaultCellStyle.Format = "dd MMM yyyy";
                if (grid.Columns.Contains("Jumlah")) grid.Columns["Jumlah"].DefaultCellStyle.Format = "N2";
            }
            catch (Exception ex) { UiHelper.Error("Gagal memuat: " + ex.Message); }
        }

        private void Grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (grid.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                var status = e.Value.ToString();
                e.CellStyle.BackColor = UiTheme.StatusColor(status);
                e.CellStyle.ForeColor = Color.White;
                e.CellStyle.SelectionBackColor = UiTheme.StatusColor(status);
                e.CellStyle.SelectionForeColor = Color.White;
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                e.CellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            }
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            using (var f = new FormPesananEdit())
                if (f.ShowDialog() == DialogResult.OK) LoadData(txtCari.Text);
        }
        private void BtnUbah_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow == null) { UiHelper.Warn("Pilih pesanan terlebih dahulu."); return; }
            using (var f = new FormPesananEdit(Convert.ToInt32(grid.CurrentRow.Cells[0].Value)))
                if (f.ShowDialog() == DialogResult.OK) LoadData(txtCari.Text);
        }
        private void BtnHapus_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow == null) { UiHelper.Warn("Pilih pesanan terlebih dahulu."); return; }
            if (!UiHelper.ConfirmDelete("pesanan")) return;
            try
            {
                Database.Execute("DELETE FROM SupplierOrders WHERE OrderId=@i", Database.P("@i", Convert.ToInt32(grid.CurrentRow.Cells[0].Value)));
                LoadData(txtCari.Text);
                UiHelper.Info("Data berhasil dihapus.");
            }
            catch (Exception ex) { UiHelper.Error("Gagal menghapus: " + ex.Message); }
        }

        private void BtnStatus_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow == null) { UiHelper.Warn("Pilih pesanan terlebih dahulu."); return; }
            string current = grid.CurrentRow.Cells["Status"].Value?.ToString();
            string next = current == "Pending" ? "Diproses" : current == "Diproses" ? "Selesai" : "Pending";

            if (MessageBox.Show($"Ubah status dari '{current}' menjadi '{next}'?", "Update Status",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            try
            {
                Database.Execute("UPDATE SupplierOrders SET Status=@s WHERE OrderId=@i",
                    Database.P("@s", next),
                    Database.P("@i", Convert.ToInt32(grid.CurrentRow.Cells[0].Value)));
                LoadData(txtCari.Text);
            }
            catch (Exception ex) { UiHelper.Error("Gagal update status: " + ex.Message); }
        }

        private void TxtCari_TextChanged(object sender, EventArgs e) => LoadData(txtCari.Text);
    }
}
