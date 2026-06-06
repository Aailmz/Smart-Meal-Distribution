namespace LKS2026.UserControls
{
    partial class UcLaporan
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label lblAwal;
        private System.Windows.Forms.Label lblAkhir;
        private System.Windows.Forms.DateTimePicker dtAwal;
        private System.Windows.Forms.DateTimePicker dtAkhir;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabBahan;
        private System.Windows.Forms.TabPage tabKebutuhan;
        private System.Windows.Forms.TabPage tabPesanan;
        private System.Windows.Forms.TabPage tabDistribusi;
        private System.Windows.Forms.DataGridView gridBahan;
        private System.Windows.Forms.DataGridView gridKebutuhan;
        private System.Windows.Forms.DataGridView gridPesanan;
        private System.Windows.Forms.DataGridView gridDistribusi;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.lblAwal = new System.Windows.Forms.Label();
            this.lblAkhir = new System.Windows.Forms.Label();
            this.dtAwal = new System.Windows.Forms.DateTimePicker();
            this.dtAkhir = new System.Windows.Forms.DateTimePicker();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabBahan = new System.Windows.Forms.TabPage();
            this.tabKebutuhan = new System.Windows.Forms.TabPage();
            this.tabPesanan = new System.Windows.Forms.TabPage();
            this.tabDistribusi = new System.Windows.Forms.TabPage();
            this.gridBahan = new System.Windows.Forms.DataGridView();
            this.gridKebutuhan = new System.Windows.Forms.DataGridView();
            this.gridPesanan = new System.Windows.Forms.DataGridView();
            this.gridDistribusi = new System.Windows.Forms.DataGridView();
            this.pnlTop.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tabBahan.SuspendLayout();
            this.tabKebutuhan.SuspendLayout();
            this.tabPesanan.SuspendLayout();
            this.tabDistribusi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBahan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKebutuhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPesanan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDistribusi)).BeginInit();
            this.SuspendLayout();
            //
            // pnlTop
            //
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.lblFilter);
            this.pnlTop.Controls.Add(this.lblAwal);
            this.pnlTop.Controls.Add(this.dtAwal);
            this.pnlTop.Controls.Add(this.lblAkhir);
            this.pnlTop.Controls.Add(this.dtAkhir);
            this.pnlTop.Controls.Add(this.btnFilter);
            this.pnlTop.Controls.Add(this.btnReset);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1000, 90);
            this.pnlTop.TabIndex = 0;
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(80, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Laporan";
            //
            // lblFilter
            //
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFilter.Location = new System.Drawing.Point(0, 50);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(95, 19);
            this.lblFilter.TabIndex = 1;
            this.lblFilter.Text = "Filter tanggal:";
            //
            // lblAwal
            //
            this.lblAwal.AutoSize = true;
            this.lblAwal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAwal.Location = new System.Drawing.Point(100, 52);
            this.lblAwal.Name = "lblAwal";
            this.lblAwal.Size = new System.Drawing.Size(33, 19);
            this.lblAwal.TabIndex = 2;
            this.lblAwal.Text = "Dari";
            //
            // dtAwal
            //
            this.dtAwal.Checked = false;
            this.dtAwal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtAwal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAwal.Location = new System.Drawing.Point(135, 47);
            this.dtAwal.Name = "dtAwal";
            this.dtAwal.ShowCheckBox = true;
            this.dtAwal.Size = new System.Drawing.Size(130, 25);
            this.dtAwal.TabIndex = 3;
            //
            // lblAkhir
            //
            this.lblAkhir.AutoSize = true;
            this.lblAkhir.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAkhir.Location = new System.Drawing.Point(275, 52);
            this.lblAkhir.Name = "lblAkhir";
            this.lblAkhir.Size = new System.Drawing.Size(28, 19);
            this.lblAkhir.TabIndex = 4;
            this.lblAkhir.Text = "s/d";
            //
            // dtAkhir
            //
            this.dtAkhir.Checked = false;
            this.dtAkhir.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAkhir.Location = new System.Drawing.Point(305, 47);
            this.dtAkhir.Name = "dtAkhir";
            this.dtAkhir.ShowCheckBox = true;
            this.dtAkhir.Size = new System.Drawing.Size(130, 25);
            this.dtAkhir.TabIndex = 5;
            //
            // btnFilter
            //
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(450, 47);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(100, 32);
            this.btnFilter.TabIndex = 6;
            this.btnFilter.Text = "Terapkan";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            //
            // btnReset
            //
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(555, 47);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 32);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            //
            // tabs
            //
            this.tabs.Controls.Add(this.tabBahan);
            this.tabs.Controls.Add(this.tabKebutuhan);
            this.tabs.Controls.Add(this.tabPesanan);
            this.tabs.Controls.Add(this.tabDistribusi);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabs.Location = new System.Drawing.Point(0, 90);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1000, 510);
            this.tabs.TabIndex = 1;
            //
            // tabBahan
            //
            this.tabBahan.BackColor = System.Drawing.Color.White;
            this.tabBahan.Controls.Add(this.gridBahan);
            this.tabBahan.Location = new System.Drawing.Point(4, 29);
            this.tabBahan.Name = "tabBahan";
            this.tabBahan.Padding = new System.Windows.Forms.Padding(3);
            this.tabBahan.Size = new System.Drawing.Size(992, 477);
            this.tabBahan.TabIndex = 0;
            this.tabBahan.Text = "Bahan Baku";
            //
            // tabKebutuhan
            //
            this.tabKebutuhan.BackColor = System.Drawing.Color.White;
            this.tabKebutuhan.Controls.Add(this.gridKebutuhan);
            this.tabKebutuhan.Location = new System.Drawing.Point(4, 29);
            this.tabKebutuhan.Name = "tabKebutuhan";
            this.tabKebutuhan.Padding = new System.Windows.Forms.Padding(3);
            this.tabKebutuhan.Size = new System.Drawing.Size(992, 477);
            this.tabKebutuhan.TabIndex = 1;
            this.tabKebutuhan.Text = "Kebutuhan Dapur";
            //
            // tabPesanan
            //
            this.tabPesanan.BackColor = System.Drawing.Color.White;
            this.tabPesanan.Controls.Add(this.gridPesanan);
            this.tabPesanan.Location = new System.Drawing.Point(4, 29);
            this.tabPesanan.Name = "tabPesanan";
            this.tabPesanan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPesanan.Size = new System.Drawing.Size(992, 477);
            this.tabPesanan.TabIndex = 2;
            this.tabPesanan.Text = "Pesanan";
            //
            // tabDistribusi
            //
            this.tabDistribusi.BackColor = System.Drawing.Color.White;
            this.tabDistribusi.Controls.Add(this.gridDistribusi);
            this.tabDistribusi.Location = new System.Drawing.Point(4, 29);
            this.tabDistribusi.Name = "tabDistribusi";
            this.tabDistribusi.Padding = new System.Windows.Forms.Padding(3);
            this.tabDistribusi.Size = new System.Drawing.Size(992, 477);
            this.tabDistribusi.TabIndex = 3;
            this.tabDistribusi.Text = "Distribusi";
            //
            // gridBahan
            //
            this.gridBahan.BackgroundColor = System.Drawing.Color.White;
            this.gridBahan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridBahan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBahan.Location = new System.Drawing.Point(3, 3);
            this.gridBahan.Name = "gridBahan";
            this.gridBahan.Size = new System.Drawing.Size(986, 471);
            this.gridBahan.TabIndex = 0;
            //
            // gridKebutuhan
            //
            this.gridKebutuhan.BackgroundColor = System.Drawing.Color.White;
            this.gridKebutuhan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridKebutuhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridKebutuhan.Location = new System.Drawing.Point(3, 3);
            this.gridKebutuhan.Name = "gridKebutuhan";
            this.gridKebutuhan.Size = new System.Drawing.Size(986, 471);
            this.gridKebutuhan.TabIndex = 0;
            //
            // gridPesanan
            //
            this.gridPesanan.BackgroundColor = System.Drawing.Color.White;
            this.gridPesanan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPesanan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPesanan.Location = new System.Drawing.Point(3, 3);
            this.gridPesanan.Name = "gridPesanan";
            this.gridPesanan.Size = new System.Drawing.Size(986, 471);
            this.gridPesanan.TabIndex = 0;
            //
            // gridDistribusi
            //
            this.gridDistribusi.BackgroundColor = System.Drawing.Color.White;
            this.gridDistribusi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDistribusi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDistribusi.Location = new System.Drawing.Point(3, 3);
            this.gridDistribusi.Name = "gridDistribusi";
            this.gridDistribusi.Size = new System.Drawing.Size(986, 471);
            this.gridDistribusi.TabIndex = 0;
            //
            // UcLaporan
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.pnlTop);
            this.Name = "UcLaporan";
            this.Size = new System.Drawing.Size(1000, 600);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.tabBahan.ResumeLayout(false);
            this.tabKebutuhan.ResumeLayout(false);
            this.tabPesanan.ResumeLayout(false);
            this.tabDistribusi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBahan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKebutuhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPesanan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDistribusi)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
