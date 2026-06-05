using System.Drawing;
using System.Windows.Forms;
using LKS2026.Helpers;

namespace LKS2026.Forms
{
    partial class FormPesananEdit
    {
        private System.ComponentModel.IContainer components = null;
        private DateTimePicker dtTanggal;
        private TextBox txtPemasok, txtJumlah, txtSatuan, txtCatatan;
        private ComboBox cmbBahan, cmbStatus;
        private Button btnSimpan, btnBatal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false; this.MinimizeBox = false;
            this.ClientSize = new Size(460, 580);
            this.BackColor = Color.White;

            int x = 30, w = 400, y = 20;
            void Add(string label, Control c, int h = 0)
            {
                this.Controls.Add(new Label { Text = label, AutoSize = true, Font = UiTheme.FontBold, Location = new Point(x, y) });
                c.Location = new Point(x, y + 22);
                c.Width = w;
                this.Controls.Add(c);
                y += 60 + h;
            }

            dtTanggal  = new DateTimePicker { Font = UiTheme.FontNormal, Format = DateTimePickerFormat.Long };
            txtPemasok = new TextBox { Font = UiTheme.FontNormal, BorderStyle = BorderStyle.FixedSingle };
            cmbBahan   = new ComboBox { Font = UiTheme.FontNormal, DropDownStyle = ComboBoxStyle.DropDownList };
            txtJumlah  = new TextBox { Font = UiTheme.FontNormal, BorderStyle = BorderStyle.FixedSingle, Text = "0" };
            txtSatuan  = new TextBox { Font = UiTheme.FontNormal, BorderStyle = BorderStyle.FixedSingle };
            cmbStatus  = new ComboBox { Font = UiTheme.FontNormal, DropDownStyle = ComboBoxStyle.DropDownList };
            cmbStatus.Items.AddRange(new object[] { "Pending", "Diproses", "Selesai" });
            txtCatatan = new TextBox { Font = UiTheme.FontNormal, BorderStyle = BorderStyle.FixedSingle, Multiline = true, Height = 50 };

            Add("Tanggal Pesanan *", dtTanggal);
            Add("Nama Pemasok *", txtPemasok);
            Add("Bahan Baku *", cmbBahan);
            Add("Jumlah Pesan *", txtJumlah);
            Add("Satuan", txtSatuan);
            Add("Status", cmbStatus);
            Add("Catatan", txtCatatan, 10);

            btnSimpan = UiHelper.MakeActionButton("Simpan", UiTheme.Primary, BtnSimpan_Click);
            btnSimpan.Size = new Size(130, 38); btnSimpan.Location = new Point(x + w - 270, y);
            btnBatal = UiHelper.MakeActionButton("Batal", UiTheme.Muted, BtnBatal_Click);
            btnBatal.Size = new Size(130, 38); btnBatal.Location = new Point(x + w - 130, y);

            this.Controls.Add(btnSimpan);
            this.Controls.Add(btnBatal);
            this.AcceptButton = btnSimpan;
            this.CancelButton = btnBatal;
            this.ResumeLayout(false);
        }
    }
}
