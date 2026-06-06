using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using LKS2026.Helpers;

namespace LKS2026.UserControls
{
    public partial class UcLaporan : UserControl
    {
        public UcLaporan()
        {
            InitializeComponent();
            tabs.SelectedIndexChanged += (s, e) => LoadCurrentReport();
            LoadCurrentReport();
        }

        // Style grid laporan biar seragam dengan grid lain
        private void StyleGrid(DataGridView g)
        {
            g.BackgroundColor = Color.White;
            g.BorderStyle = BorderStyle.None;
            g.GridColor = Color.FromArgb(230, 230, 230);
            g.RowHeadersVisible = false;
            g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            g.MultiSelect = false;
            g.AllowUserToAddRows = false;
            g.AllowUserToDeleteRows = false;
            g.AllowUserToResizeRows = false;
            g.ReadOnly = true;
            g.RowTemplate.Height = 32;
            g.EnableHeadersVisualStyles = false;
            g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            g.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            g.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            g.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            g.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            g.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 0, 0);
            g.ColumnHeadersHeight = 38;
            g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            g.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            g.DefaultCellStyle.SelectionBackColor = Color.FromArgb(204, 228, 247);
            g.DefaultCellStyle.SelectionForeColor = Color.FromArgb(33, 37, 41);
            g.DefaultCellStyle.Padding = new Padding(6, 0, 0, 0);
            g.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);
        }

        private void BtnFilter_Click(object sender, EventArgs e) => LoadCurrentReport();

        private void BtnReset_Click(object sender, EventArgs e)
        {
            dtAwal.Checked = false;
            dtAkhir.Checked = false;
            LoadCurrentReport();
        }

        private (string, SqlParameter[]) GetDateClause(string dateCol)
        {
            if (dtAwal.Checked && dtAkhir.Checked)
            {
                return (" WHERE " + dateCol + " BETWEEN @a AND @b",
                    new[] { Database.P("@a", dtAwal.Value.Date), Database.P("@b", dtAkhir.Value.Date) });
            }
            return ("", new SqlParameter[0]);
        }

        private void LoadCurrentReport()
        {
            try
            {
                switch (tabs.SelectedIndex)
                {
                    case 0: // Bahan Baku
                        gridBahan.DataSource = Database.Query(
                            @"SELECT MaterialName AS [Nama], Category AS [Kategori], Unit AS [Satuan],
                                     Stock AS [Stok], EstimatedPrice AS [Harga]
                              FROM RawMaterials ORDER BY MaterialName");
                        StyleGrid(gridBahan);
                        break;
                    case 1: // Kebutuhan Dapur
                    {
                        var (clause, pars) = GetDateClause("k.NeedDate");
                        gridKebutuhan.DataSource = Database.Query(
                            @"SELECT k.NeedDate AS [Tanggal], m.MaterialName AS [Bahan], k.Quantity AS [Jumlah],
                                     k.Unit AS [Satuan], k.Notes AS [Keterangan]
                              FROM KitchenNeeds k INNER JOIN RawMaterials m ON k.MaterialId=m.MaterialId"
                            + clause + " ORDER BY k.NeedDate DESC", pars);
                        StyleGrid(gridKebutuhan);
                        if (gridKebutuhan.Columns.Contains("Tanggal")) gridKebutuhan.Columns["Tanggal"].DefaultCellStyle.Format = "dd MMM yyyy";
                        break;
                    }
                    case 2: // Pesanan
                    {
                        var (clause, pars) = GetDateClause("o.OrderDate");
                        gridPesanan.DataSource = Database.Query(
                            @"SELECT o.OrderDate AS [Tanggal], o.SupplierName AS [Pemasok], m.MaterialName AS [Bahan],
                                     o.OrderQuantity AS [Jumlah], o.Unit AS [Satuan], o.Status AS [Status]
                              FROM SupplierOrders o INNER JOIN RawMaterials m ON o.MaterialId=m.MaterialId"
                            + clause + " ORDER BY o.OrderDate DESC", pars);
                        StyleGrid(gridPesanan);
                        if (gridPesanan.Columns.Contains("Tanggal")) gridPesanan.Columns["Tanggal"].DefaultCellStyle.Format = "dd MMM yyyy";
                        break;
                    }
                    case 3: // Distribusi
                    {
                        var (clause, pars) = GetDateClause("p.ProcessDate");
                        gridDistribusi.DataSource = Database.Query(
                            @"SELECT p.ProcessDate AS [Tanggal], s.SchoolName AS [Sekolah], p.PortionCount AS [Porsi],
                                     p.ProductionStatus AS [Produksi], p.DistributionStatus AS [Distribusi]
                              FROM ProductionDistribution p INNER JOIN Schools s ON p.SchoolId=s.SchoolId"
                            + clause + " ORDER BY p.ProcessDate DESC", pars);
                        StyleGrid(gridDistribusi);
                        if (gridDistribusi.Columns.Contains("Tanggal")) gridDistribusi.Columns["Tanggal"].DefaultCellStyle.Format = "dd MMM yyyy";
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat laporan: " + ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
