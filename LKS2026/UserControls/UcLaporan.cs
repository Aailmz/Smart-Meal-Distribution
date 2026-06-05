using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
                        UiHelper.StyleGrid(gridBahan);
                        break;
                    case 1: // Kebutuhan Dapur
                    {
                        var (clause, pars) = GetDateClause("k.NeedDate");
                        gridKebutuhan.DataSource = Database.Query(
                            @"SELECT k.NeedDate AS [Tanggal], m.MaterialName AS [Bahan], k.Quantity AS [Jumlah],
                                     k.Unit AS [Satuan], k.Notes AS [Keterangan]
                              FROM KitchenNeeds k INNER JOIN RawMaterials m ON k.MaterialId=m.MaterialId"
                            + clause + " ORDER BY k.NeedDate DESC", pars);
                        UiHelper.StyleGrid(gridKebutuhan);
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
                        UiHelper.StyleGrid(gridPesanan);
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
                        UiHelper.StyleGrid(gridDistribusi);
                        if (gridDistribusi.Columns.Contains("Tanggal")) gridDistribusi.Columns["Tanggal"].DefaultCellStyle.Format = "dd MMM yyyy";
                        break;
                    }
                }
            }
            catch (Exception ex) { UiHelper.Error("Gagal memuat laporan: " + ex.Message); }
        }
    }
}
