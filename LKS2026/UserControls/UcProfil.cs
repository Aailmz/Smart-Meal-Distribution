using System.Windows.Forms;
using LKS2026.Helpers;

namespace LKS2026.UserControls
{
    public partial class UcProfil : UserControl
    {
        public UcProfil()
        {
            InitializeComponent();
            lblUsernameVal.Text = Session.Username ?? "-";
            lblFullNameVal.Text = Session.FullName ?? "-";
            lblRoleVal.Text     = Session.Role == "PetugasSPPG" ? "Petugas SPPG"
                                : Session.Role == "SupervisorSPPG" ? "Supervisor SPPG"
                                : (Session.Role ?? "-");
            lblPositionVal.Text = string.IsNullOrEmpty(Session.Position) ? "-" : Session.Position;
        }
    }
}
