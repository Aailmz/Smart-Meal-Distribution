using System;
using System.Windows.Forms;
using LKS2026.Helpers;

namespace LKS2026.Forms
{
    public partial class FormPegawaiEdit : Form
    {
        private readonly int? _id;

        public FormPegawaiEdit() { InitializeComponent(); Text = "Tambah Pegawai"; }
        public FormPegawaiEdit(int id) : this()
        {
            _id = id;
            Text = "Ubah Pegawai";
            LoadEntity();
        }

        private void LoadEntity()
        {
            try
            {
                var dt = Database.Query("SELECT * FROM Employees WHERE EmployeeId=@i", Database.P("@i", _id));
                if (dt.Rows.Count == 0) { MessageBox.Show("Data tidak ditemukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning); Close(); return; }
                var r = dt.Rows[0];
                txtNama.Text = r["EmployeeName"].ToString();
                txtJabatan.Text = r["Position"].ToString();
                txtHp.Text = r["Phone"].ToString();
                txtAlamat.Text = r["Address"].ToString();
            }
            catch (Exception ex) { MessageBox.Show("Gagal memuat: " + ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text)) { MessageBox.Show("Nama pegawai wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            try
            {
                if (_id.HasValue)
                {
                    Database.Execute(@"UPDATE Employees SET EmployeeName=@n, Position=@j, Phone=@p, Address=@a WHERE EmployeeId=@i",
                        Database.P("@n", txtNama.Text.Trim()),
                        Database.P("@j", txtJabatan.Text.Trim()),
                        Database.P("@p", txtHp.Text.Trim()),
                        Database.P("@a", txtAlamat.Text.Trim()),
                        Database.P("@i", _id.Value));
                }
                else
                {
                    Database.Execute(@"INSERT INTO Employees (EmployeeName, Position, Phone, Address) VALUES (@n,@j,@p,@a)",
                        Database.P("@n", txtNama.Text.Trim()),
                        Database.P("@j", txtJabatan.Text.Trim()),
                        Database.P("@p", txtHp.Text.Trim()),
                        Database.P("@a", txtAlamat.Text.Trim()));
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex) { MessageBox.Show("Gagal menyimpan: " + ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void BtnBatal_Click(object sender, EventArgs e) { DialogResult = DialogResult.Cancel; Close(); }
    }
}
