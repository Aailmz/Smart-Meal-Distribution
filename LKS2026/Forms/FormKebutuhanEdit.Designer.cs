namespace LKS2026.Forms
{
    partial class FormKebutuhanEdit
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Label lblBahan;
        private System.Windows.Forms.Label lblJumlah;
        private System.Windows.Forms.Label lblSatuan;
        private System.Windows.Forms.Label lblCatatan;
        private System.Windows.Forms.DateTimePicker dtTanggal;
        private System.Windows.Forms.ComboBox cmbBahan;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.TextBox txtSatuan;
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
            this.lblBahan = new System.Windows.Forms.Label();
            this.lblJumlah = new System.Windows.Forms.Label();
            this.lblSatuan = new System.Windows.Forms.Label();
            this.lblCatatan = new System.Windows.Forms.Label();
            this.dtTanggal = new System.Windows.Forms.DateTimePicker();
            this.cmbBahan = new System.Windows.Forms.ComboBox();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.txtSatuan = new System.Windows.Forms.TextBox();
            this.txtCatatan = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblTanggal
            //
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTanggal.Location = new System.Drawing.Point(30, 20);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(150, 19);
            this.lblTanggal.TabIndex = 0;
            this.lblTanggal.Text = "Tanggal Kebutuhan *";
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
            // lblBahan
            //
            this.lblBahan.AutoSize = true;
            this.lblBahan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBahan.Location = new System.Drawing.Point(30, 80);
            this.lblBahan.Name = "lblBahan";
            this.lblBahan.Size = new System.Drawing.Size(95, 19);
            this.lblBahan.TabIndex = 2;
            this.lblBahan.Text = "Bahan Baku *";
            //
            // cmbBahan
            //
            this.cmbBahan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBahan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbBahan.Location = new System.Drawing.Point(30, 102);
            this.cmbBahan.Name = "cmbBahan";
            this.cmbBahan.Size = new System.Drawing.Size(400, 25);
            this.cmbBahan.TabIndex = 3;
            //
            // lblJumlah
            //
            this.lblJumlah.AutoSize = true;
            this.lblJumlah.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblJumlah.Location = new System.Drawing.Point(30, 140);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(150, 19);
            this.lblJumlah.TabIndex = 4;
            this.lblJumlah.Text = "Jumlah Kebutuhan *";
            //
            // txtJumlah
            //
            this.txtJumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJumlah.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtJumlah.Location = new System.Drawing.Point(30, 162);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(400, 25);
            this.txtJumlah.TabIndex = 5;
            this.txtJumlah.Text = "0";
            //
            // lblSatuan
            //
            this.lblSatuan.AutoSize = true;
            this.lblSatuan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSatuan.Location = new System.Drawing.Point(30, 200);
            this.lblSatuan.Name = "lblSatuan";
            this.lblSatuan.Size = new System.Drawing.Size(55, 19);
            this.lblSatuan.TabIndex = 6;
            this.lblSatuan.Text = "Satuan";
            //
            // txtSatuan
            //
            this.txtSatuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSatuan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSatuan.Location = new System.Drawing.Point(30, 222);
            this.txtSatuan.Name = "txtSatuan";
            this.txtSatuan.Size = new System.Drawing.Size(400, 25);
            this.txtSatuan.TabIndex = 7;
            //
            // lblCatatan
            //
            this.lblCatatan.AutoSize = true;
            this.lblCatatan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCatatan.Location = new System.Drawing.Point(30, 260);
            this.lblCatatan.Name = "lblCatatan";
            this.lblCatatan.Size = new System.Drawing.Size(80, 19);
            this.lblCatatan.TabIndex = 8;
            this.lblCatatan.Text = "Keterangan";
            //
            // txtCatatan
            //
            this.txtCatatan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCatatan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCatatan.Location = new System.Drawing.Point(30, 282);
            this.txtCatatan.Multiline = true;
            this.txtCatatan.Name = "txtCatatan";
            this.txtCatatan.Size = new System.Drawing.Size(400, 50);
            this.txtCatatan.TabIndex = 9;
            //
            // btnSimpan
            //
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(160, 330);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(130, 38);
            this.btnSimpan.TabIndex = 10;
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
            this.btnBatal.Location = new System.Drawing.Point(300, 330);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(130, 38);
            this.btnBatal.TabIndex = 11;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.BtnBatal_Click);
            //
            // FormKebutuhanEdit
            //
            this.AcceptButton = this.btnSimpan;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnBatal;
            this.ClientSize = new System.Drawing.Size(460, 460);
            this.Controls.Add(this.lblTanggal);
            this.Controls.Add(this.dtTanggal);
            this.Controls.Add(this.lblBahan);
            this.Controls.Add(this.cmbBahan);
            this.Controls.Add(this.lblJumlah);
            this.Controls.Add(this.txtJumlah);
            this.Controls.Add(this.lblSatuan);
            this.Controls.Add(this.txtSatuan);
            this.Controls.Add(this.lblCatatan);
            this.Controls.Add(this.txtCatatan);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnBatal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormKebutuhanEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tambah Kebutuhan Dapur";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
