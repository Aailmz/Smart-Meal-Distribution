namespace LKS2026.Forms
{
    partial class FormMonitoringEdit
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Label lblSekolah;
        private System.Windows.Forms.Label lblPorsi;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.Label lblDist;
        private System.Windows.Forms.Label lblCatatan;
        private System.Windows.Forms.DateTimePicker dtTanggal;
        private System.Windows.Forms.ComboBox cmbSekolah;
        private System.Windows.Forms.NumericUpDown numPorsi;
        private System.Windows.Forms.ComboBox cmbProd;
        private System.Windows.Forms.ComboBox cmbDist;
        private System.Windows.Forms.TextBox txtCatatan;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTanggal = new System.Windows.Forms.Label();
            this.lblSekolah = new System.Windows.Forms.Label();
            this.lblPorsi = new System.Windows.Forms.Label();
            this.lblProd = new System.Windows.Forms.Label();
            this.lblDist = new System.Windows.Forms.Label();
            this.lblCatatan = new System.Windows.Forms.Label();
            this.dtTanggal = new System.Windows.Forms.DateTimePicker();
            this.cmbSekolah = new System.Windows.Forms.ComboBox();
            this.numPorsi = new System.Windows.Forms.NumericUpDown();
            this.cmbProd = new System.Windows.Forms.ComboBox();
            this.cmbDist = new System.Windows.Forms.ComboBox();
            this.txtCatatan = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPorsi)).BeginInit();
            this.SuspendLayout();
            //
            // lblTanggal
            //
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTanggal.Location = new System.Drawing.Point(30, 20);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(120, 19);
            this.lblTanggal.TabIndex = 0;
            this.lblTanggal.Text = "Tanggal Proses *";
            //
            // dtTanggal
            //
            this.dtTanggal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtTanggal.Location = new System.Drawing.Point(30, 42);
            this.dtTanggal.Name = "dtTanggal";
            this.dtTanggal.Size = new System.Drawing.Size(400, 25);
            this.dtTanggal.TabIndex = 1;
            //
            // lblSekolah
            //
            this.lblSekolah.AutoSize = true;
            this.lblSekolah.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSekolah.Location = new System.Drawing.Point(30, 80);
            this.lblSekolah.Name = "lblSekolah";
            this.lblSekolah.Size = new System.Drawing.Size(140, 19);
            this.lblSekolah.TabIndex = 2;
            this.lblSekolah.Text = "Sekolah Penerima *";
            //
            // cmbSekolah
            //
            this.cmbSekolah.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSekolah.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSekolah.Location = new System.Drawing.Point(30, 102);
            this.cmbSekolah.Name = "cmbSekolah";
            this.cmbSekolah.Size = new System.Drawing.Size(400, 25);
            this.cmbSekolah.TabIndex = 3;
            //
            // lblPorsi
            //
            this.lblPorsi.AutoSize = true;
            this.lblPorsi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPorsi.Location = new System.Drawing.Point(30, 140);
            this.lblPorsi.Name = "lblPorsi";
            this.lblPorsi.Size = new System.Drawing.Size(85, 19);
            this.lblPorsi.TabIndex = 4;
            this.lblPorsi.Text = "Jumlah Porsi";
            //
            // numPorsi
            //
            this.numPorsi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numPorsi.Location = new System.Drawing.Point(30, 162);
            this.numPorsi.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.numPorsi.Name = "numPorsi";
            this.numPorsi.Size = new System.Drawing.Size(400, 25);
            this.numPorsi.TabIndex = 5;
            //
            // lblProd
            //
            this.lblProd.AutoSize = true;
            this.lblProd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblProd.Location = new System.Drawing.Point(30, 200);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(110, 19);
            this.lblProd.TabIndex = 6;
            this.lblProd.Text = "Status Produksi";
            //
            // cmbProd
            //
            this.cmbProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbProd.Items.AddRange(new object[] {
            "Belum Diproses",
            "Diproses",
            "Selesai"});
            this.cmbProd.Location = new System.Drawing.Point(30, 222);
            this.cmbProd.Name = "cmbProd";
            this.cmbProd.Size = new System.Drawing.Size(400, 25);
            this.cmbProd.TabIndex = 7;
            //
            // lblDist
            //
            this.lblDist.AutoSize = true;
            this.lblDist.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDist.Location = new System.Drawing.Point(30, 260);
            this.lblDist.Name = "lblDist";
            this.lblDist.Size = new System.Drawing.Size(120, 19);
            this.lblDist.TabIndex = 8;
            this.lblDist.Text = "Status Distribusi";
            //
            // cmbDist
            //
            this.cmbDist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDist.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDist.Items.AddRange(new object[] {
            "Belum Dikirim",
            "Dikirim",
            "Selesai"});
            this.cmbDist.Location = new System.Drawing.Point(30, 282);
            this.cmbDist.Name = "cmbDist";
            this.cmbDist.Size = new System.Drawing.Size(400, 25);
            this.cmbDist.TabIndex = 9;
            //
            // lblCatatan
            //
            this.lblCatatan.AutoSize = true;
            this.lblCatatan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCatatan.Location = new System.Drawing.Point(30, 320);
            this.lblCatatan.Name = "lblCatatan";
            this.lblCatatan.Size = new System.Drawing.Size(65, 19);
            this.lblCatatan.TabIndex = 10;
            this.lblCatatan.Text = "Catatan";
            //
            // txtCatatan
            //
            this.txtCatatan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCatatan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCatatan.Location = new System.Drawing.Point(30, 342);
            this.txtCatatan.Multiline = true;
            this.txtCatatan.Name = "txtCatatan";
            this.txtCatatan.Size = new System.Drawing.Size(400, 50);
            this.txtCatatan.TabIndex = 11;
            //
            // btnSimpan
            //
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(160, 410);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(130, 38);
            this.btnSimpan.TabIndex = 12;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            //
            // btnBatal
            //
            this.btnBatal.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBatal.FlatAppearance.BorderSize = 0;
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnBatal.ForeColor = System.Drawing.Color.White;
            this.btnBatal.Location = new System.Drawing.Point(300, 410);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(130, 38);
            this.btnBatal.TabIndex = 13;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.BtnBatal_Click);
            //
            // FormMonitoringEdit
            //
            this.AcceptButton = this.btnSimpan;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnBatal;
            this.ClientSize = new System.Drawing.Size(460, 540);
            this.Controls.Add(this.lblTanggal);
            this.Controls.Add(this.dtTanggal);
            this.Controls.Add(this.lblSekolah);
            this.Controls.Add(this.cmbSekolah);
            this.Controls.Add(this.lblPorsi);
            this.Controls.Add(this.numPorsi);
            this.Controls.Add(this.lblProd);
            this.Controls.Add(this.cmbProd);
            this.Controls.Add(this.lblDist);
            this.Controls.Add(this.cmbDist);
            this.Controls.Add(this.lblCatatan);
            this.Controls.Add(this.txtCatatan);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnBatal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMonitoringEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tambah Produksi/Distribusi";
            ((System.ComponentModel.ISupportInitialize)(this.numPorsi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
