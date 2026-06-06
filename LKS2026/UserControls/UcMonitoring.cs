using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using LKS2026.Forms;
using LKS2026.Helpers;

namespace LKS2026.UserControls
{
    public partial class UcMonitoring : UserControl
    {
        public UcMonitoring()
        {
            InitializeComponent();
            cmbFilterStatus.SelectedIndex = 0;
            LoadData();
            // Monitoring khusus Supervisor (sesuai Tabel 6): full akses CRUD + validasi status
            btnTambah.Enabled     = true;
            btnUbah.Enabled       = true;
            btnHapus.Enabled      = true;
            btnStatusProd.Enabled = true;
            btnStatusDist.Enabled = true;
        }

        // Warna badge status: Belum=kuning, Diproses/Dikirim=biru info, Selesai=hijau
        private Color StatusColor(string status)
        {
            if (string.IsNullOrEmpty(status)) return Color.FromArgb(108, 117, 125);
            switch (status.Trim().ToLowerInvariant())
            {
                case "belum diproses":
                case "belum dikirim":
                    return Color.FromArgb(255, 193, 7);
                case "diproses":
                case "dikirim":
                    return Color.FromArgb(23, 162, 184);
                case "selesai":
                    return Color.FromArgb(40, 167, 69);
                default:
                    return Color.FromArgb(108, 117, 125);
            }
        }

        private void LoadData()
        {
            try
            {
                var conditions = "";
                var pars = new System.Collections.Generic.List<SqlParameter>();
                if (dtAwal.Checked && dtAkhir.Checked)
                {
                    conditions += " AND p.ProcessDate BETWEEN @a AND @b";
                    pars.Add(Database.P("@a", dtAwal.Value.Date));
                    pars.Add(Database.P("@b", dtAkhir.Value.Date));
                }
                if (cmbFilterStatus.SelectedIndex > 0)
                {
                    conditions += " AND (p.ProductionStatus = @s OR p.DistributionStatus = @s)";
                    pars.Add(Database.P("@s", cmbFilterStatus.SelectedItem.ToString()));
                }

                string sql = @"SELECT p.ProcessId AS [ID], p.ProcessDate AS [Tanggal], s.SchoolName AS [Sekolah],
                                      p.PortionCount AS [Porsi], p.ProductionStatus AS [Status Produksi],
                                      p.DistributionStatus AS [Status Distribusi], p.Notes AS [Catatan]
                               FROM ProductionDistribution p
                               INNER JOIN Schools s ON p.SchoolId = s.SchoolId
                               WHERE 1=1" + conditions + " ORDER BY p.ProcessDate DESC, p.ProcessId DESC";

                grid.DataSource = Database.Query(sql, pars.ToArray());
                if (grid.Columns.Contains("Tanggal")) grid.Columns["Tanggal"].DefaultCellStyle.Format = "dd MMM yyyy";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat: " + ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.Value == null) return;
            var col = grid.Columns[e.ColumnIndex].Name;
            if (col == "Status Produksi" || col == "Status Distribusi")
            {
                var color = StatusColor(e.Value.ToString());
                e.CellStyle.BackColor = color;
                e.CellStyle.ForeColor = Color.White;
                e.CellStyle.SelectionBackColor = color;
                e.CellStyle.SelectionForeColor = Color.White;
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                e.CellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            }
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            using (var f = new FormMonitoringEdit())
                if (f.ShowDialog() == DialogResult.OK) LoadData();
        }

        private void BtnUbah_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow == null) { MessageBox.Show("Pilih data terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            using (var f = new FormMonitoringEdit(Convert.ToInt32(grid.CurrentRow.Cells[0].Value)))
                if (f.ShowDialog() == DialogResult.OK) LoadData();
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow == null) { MessageBox.Show("Pilih data terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (MessageBox.Show("Yakin ingin menghapus data monitoring yang dipilih?\nTindakan ini tidak dapat dibatalkan.", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            try
            {
                Database.Execute("DELETE FROM ProductionDistribution WHERE ProcessId=@i",
                    Database.P("@i", Convert.ToInt32(grid.CurrentRow.Cells[0].Value)));
                LoadData();
                MessageBox.Show("Data berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus: " + ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnStatusProd_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow == null) { MessageBox.Show("Pilih data terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            string cur = grid.CurrentRow.Cells["Status Produksi"].Value?.ToString();
            string next = cur == "Belum Diproses" ? "Diproses" : cur == "Diproses" ? "Selesai" : "Belum Diproses";
            if (MessageBox.Show($"Ubah status produksi dari '{cur}' menjadi '{next}'?", "Update Status Produksi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            try
            {
                Database.Execute("UPDATE ProductionDistribution SET ProductionStatus=@s WHERE ProcessId=@i",
                    Database.P("@s", next),
                    Database.P("@i", Convert.ToInt32(grid.CurrentRow.Cells[0].Value)));
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal update status: " + ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnStatusDist_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow == null) { MessageBox.Show("Pilih data terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            string cur = grid.CurrentRow.Cells["Status Distribusi"].Value?.ToString();
            string next = cur == "Belum Dikirim" ? "Dikirim" : cur == "Dikirim" ? "Selesai" : "Belum Dikirim";
            if (MessageBox.Show($"Ubah status distribusi dari '{cur}' menjadi '{next}'?", "Update Status Distribusi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            try
            {
                Database.Execute("UPDATE ProductionDistribution SET DistributionStatus=@s WHERE ProcessId=@i",
                    Database.P("@s", next),
                    Database.P("@i", Convert.ToInt32(grid.CurrentRow.Cells[0].Value)));
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal update status: " + ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnFilter_Click(object sender, EventArgs e) => LoadData();

        private void BtnReset_Click(object sender, EventArgs e)
        {
            dtAwal.Checked = false;
            dtAkhir.Checked = false;
            cmbFilterStatus.SelectedIndex = 0;
            LoadData();
        }
    }
}
