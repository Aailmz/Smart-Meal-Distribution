namespace LKS2026.UserControls
{
    partial class UcProfil
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel card;
        private System.Windows.Forms.Panel hdr;
        private System.Windows.Forms.Label avatar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUserCap;
        private System.Windows.Forms.Label lblNameCap;
        private System.Windows.Forms.Label lblRoleCap;
        private System.Windows.Forms.Label lblPosCap;
        private System.Windows.Forms.Label lblUsernameVal;
        private System.Windows.Forms.Label lblFullNameVal;
        private System.Windows.Forms.Label lblRoleVal;
        private System.Windows.Forms.Label lblPositionVal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.card = new System.Windows.Forms.Panel();
            this.hdr = new System.Windows.Forms.Panel();
            this.avatar = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUserCap = new System.Windows.Forms.Label();
            this.lblNameCap = new System.Windows.Forms.Label();
            this.lblRoleCap = new System.Windows.Forms.Label();
            this.lblPosCap = new System.Windows.Forms.Label();
            this.lblUsernameVal = new System.Windows.Forms.Label();
            this.lblFullNameVal = new System.Windows.Forms.Label();
            this.lblRoleVal = new System.Windows.Forms.Label();
            this.lblPositionVal = new System.Windows.Forms.Label();
            this.card.SuspendLayout();
            this.hdr.SuspendLayout();
            this.SuspendLayout();
            //
            // card
            //
            this.card.BackColor = System.Drawing.Color.White;
            this.card.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card.Controls.Add(this.hdr);
            this.card.Controls.Add(this.lblUserCap);
            this.card.Controls.Add(this.lblUsernameVal);
            this.card.Controls.Add(this.lblNameCap);
            this.card.Controls.Add(this.lblFullNameVal);
            this.card.Controls.Add(this.lblRoleCap);
            this.card.Controls.Add(this.lblRoleVal);
            this.card.Controls.Add(this.lblPosCap);
            this.card.Controls.Add(this.lblPositionVal);
            this.card.Location = new System.Drawing.Point(40, 30);
            this.card.Name = "card";
            this.card.Size = new System.Drawing.Size(560, 380);
            this.card.TabIndex = 0;
            //
            // hdr
            //
            this.hdr.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.hdr.Controls.Add(this.avatar);
            this.hdr.Controls.Add(this.lblTitle);
            this.hdr.Dock = System.Windows.Forms.DockStyle.Top;
            this.hdr.Location = new System.Drawing.Point(0, 0);
            this.hdr.Name = "hdr";
            this.hdr.Size = new System.Drawing.Size(558, 90);
            this.hdr.TabIndex = 0;
            //
            // avatar
            //
            this.avatar.Font = new System.Drawing.Font("Segoe UI Emoji", 32F, System.Drawing.FontStyle.Bold);
            this.avatar.ForeColor = System.Drawing.Color.White;
            this.avatar.Location = new System.Drawing.Point(20, 13);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(64, 64);
            this.avatar.TabIndex = 0;
            this.avatar.Text = "👤";
            this.avatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(100, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(160, 30);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Profil Pengguna";
            //
            // lblUserCap
            //
            this.lblUserCap.AutoSize = true;
            this.lblUserCap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUserCap.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.lblUserCap.Location = new System.Drawing.Point(40, 120);
            this.lblUserCap.Name = "lblUserCap";
            this.lblUserCap.Size = new System.Drawing.Size(70, 19);
            this.lblUserCap.TabIndex = 1;
            this.lblUserCap.Text = "Username";
            //
            // lblUsernameVal
            //
            this.lblUsernameVal.AutoSize = true;
            this.lblUsernameVal.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblUsernameVal.Location = new System.Drawing.Point(200, 120);
            this.lblUsernameVal.Name = "lblUsernameVal";
            this.lblUsernameVal.Size = new System.Drawing.Size(16, 20);
            this.lblUsernameVal.TabIndex = 2;
            this.lblUsernameVal.Text = "-";
            //
            // lblNameCap
            //
            this.lblNameCap.AutoSize = true;
            this.lblNameCap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNameCap.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.lblNameCap.Location = new System.Drawing.Point(40, 170);
            this.lblNameCap.Name = "lblNameCap";
            this.lblNameCap.Size = new System.Drawing.Size(95, 19);
            this.lblNameCap.TabIndex = 3;
            this.lblNameCap.Text = "Nama Lengkap";
            //
            // lblFullNameVal
            //
            this.lblFullNameVal.AutoSize = true;
            this.lblFullNameVal.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblFullNameVal.Location = new System.Drawing.Point(200, 170);
            this.lblFullNameVal.Name = "lblFullNameVal";
            this.lblFullNameVal.Size = new System.Drawing.Size(16, 20);
            this.lblFullNameVal.TabIndex = 4;
            this.lblFullNameVal.Text = "-";
            //
            // lblRoleCap
            //
            this.lblRoleCap.AutoSize = true;
            this.lblRoleCap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRoleCap.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.lblRoleCap.Location = new System.Drawing.Point(40, 220);
            this.lblRoleCap.Name = "lblRoleCap";
            this.lblRoleCap.Size = new System.Drawing.Size(40, 19);
            this.lblRoleCap.TabIndex = 5;
            this.lblRoleCap.Text = "Role";
            //
            // lblRoleVal
            //
            this.lblRoleVal.AutoSize = true;
            this.lblRoleVal.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblRoleVal.Location = new System.Drawing.Point(200, 220);
            this.lblRoleVal.Name = "lblRoleVal";
            this.lblRoleVal.Size = new System.Drawing.Size(16, 20);
            this.lblRoleVal.TabIndex = 6;
            this.lblRoleVal.Text = "-";
            //
            // lblPosCap
            //
            this.lblPosCap.AutoSize = true;
            this.lblPosCap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPosCap.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.lblPosCap.Location = new System.Drawing.Point(40, 270);
            this.lblPosCap.Name = "lblPosCap";
            this.lblPosCap.Size = new System.Drawing.Size(60, 19);
            this.lblPosCap.TabIndex = 7;
            this.lblPosCap.Text = "Jabatan";
            //
            // lblPositionVal
            //
            this.lblPositionVal.AutoSize = true;
            this.lblPositionVal.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPositionVal.Location = new System.Drawing.Point(200, 270);
            this.lblPositionVal.Name = "lblPositionVal";
            this.lblPositionVal.Size = new System.Drawing.Size(16, 20);
            this.lblPositionVal.TabIndex = 8;
            this.lblPositionVal.Text = "-";
            //
            // UcProfil
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.card);
            this.Name = "UcProfil";
            this.Size = new System.Drawing.Size(1000, 600);
            this.card.ResumeLayout(false);
            this.card.PerformLayout();
            this.hdr.ResumeLayout(false);
            this.hdr.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
