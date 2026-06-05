using System;
using System.Data;
using System.Windows.Forms;
using LKS2026.Helpers;

namespace LKS2026.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                ShowError("Username dan password wajib diisi.");
                return;
            }

            try
            {
                var dt = Database.Query(
                    "SELECT UserId, Username, FullName, Role, Position FROM Users WHERE Username=@u AND Password=@p",
                    Database.P("@u", username),
                    Database.P("@p", password));

                if (dt.Rows.Count == 0)
                {
                    ShowError("Username atau password salah.");
                    txtPassword.Clear();
                    txtPassword.Focus();
                    return;
                }

                var row = dt.Rows[0];
                Session.Set(
                    Convert.ToInt32(row["UserId"]),
                    row["Username"].ToString(),
                    row["FullName"].ToString(),
                    row["Role"].ToString(),
                    row["Position"]?.ToString());

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                ShowError("Gagal login: " + ex.Message);
            }
        }

        private void BtnBatal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ShowError(string msg)
        {
            lblError.Text = msg;
            lblError.Visible = true;
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                BtnLogin_Click(sender, EventArgs.Empty);
            }
        }
    }
}
