using System.Drawing;
using System.Windows.Forms;
using LKS2026.Helpers;

namespace LKS2026.UserControls
{
    partial class UcLaporan
    {
        private System.ComponentModel.IContainer components = null;
        private Panel pnlTop;
        private Label lblTitle, lblFilter, lblAwal, lblAkhir;
        private DateTimePicker dtAwal, dtAkhir;
        private Button btnFilter, btnReset;
        private TabControl tabs;
        private TabPage tabBahan, tabKebutuhan, tabPesanan, tabDistribusi;
        private DataGridView gridBahan, gridKebutuhan, gridPesanan, gridDistribusi;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.BackColor = UiTheme.ContentBg;

            pnlTop = new Panel { Dock = DockStyle.Top, Height = 90 };
            lblTitle = new Label { Text = "Laporan", Font = new Font("Segoe UI", 14F, FontStyle.Bold), AutoSize = true, Location = new Point(0, 0) };
            lblFilter = new Label { Text = "Filter tanggal:", Font = UiTheme.FontBold, AutoSize = true, Location = new Point(0, 50) };
            lblAwal = new Label { Text = "Dari", Font = UiTheme.FontNormal, AutoSize = true, Location = new Point(100, 52) };
            dtAwal = new DateTimePicker { Font = UiTheme.FontNormal, Format = DateTimePickerFormat.Short, ShowCheckBox = true, Checked = false, Location = new Point(135, 47), Width = 130 };
            lblAkhir = new Label { Text = "s/d", Font = UiTheme.FontNormal, AutoSize = true, Location = new Point(275, 52) };
            dtAkhir = new DateTimePicker { Font = UiTheme.FontNormal, Format = DateTimePickerFormat.Short, ShowCheckBox = true, Checked = false, Location = new Point(305, 47), Width = 130 };
            btnFilter = UiHelper.MakeActionButton("Terapkan", UiTheme.Primary, BtnFilter_Click); btnFilter.Size = new Size(100, 32); btnFilter.Location = new Point(450, 47);
            btnReset = UiHelper.MakeActionButton("Reset", UiTheme.Muted, BtnReset_Click); btnReset.Size = new Size(80, 32); btnReset.Location = new Point(555, 47);
            pnlTop.Controls.AddRange(new Control[] { lblTitle, lblFilter, lblAwal, dtAwal, lblAkhir, dtAkhir, btnFilter, btnReset });

            tabs = new TabControl { Dock = DockStyle.Fill, Font = UiTheme.FontNormal };

            gridBahan = new DataGridView { Dock = DockStyle.Fill };
            tabBahan = new TabPage("Bahan Baku") { BackColor = Color.White };
            tabBahan.Controls.Add(gridBahan);

            gridKebutuhan = new DataGridView { Dock = DockStyle.Fill };
            tabKebutuhan = new TabPage("Kebutuhan Dapur") { BackColor = Color.White };
            tabKebutuhan.Controls.Add(gridKebutuhan);

            gridPesanan = new DataGridView { Dock = DockStyle.Fill };
            tabPesanan = new TabPage("Pesanan") { BackColor = Color.White };
            tabPesanan.Controls.Add(gridPesanan);

            gridDistribusi = new DataGridView { Dock = DockStyle.Fill };
            tabDistribusi = new TabPage("Distribusi") { BackColor = Color.White };
            tabDistribusi.Controls.Add(gridDistribusi);

            tabs.TabPages.AddRange(new[] { tabBahan, tabKebutuhan, tabPesanan, tabDistribusi });

            this.Controls.Add(tabs);
            this.Controls.Add(pnlTop);
            this.ResumeLayout(false);
        }
    }
}
