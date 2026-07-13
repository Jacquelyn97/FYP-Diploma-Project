using System;
using System.Windows.Forms;

namespace Final
{
    public partial class VPN : UserControl
    {
        public VPN()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            FreeVPN fvpn = new FreeVPN();
            fvpn.StartPosition = FormStartPosition.Manual;
            fvpn.Left = 560;
            fvpn.Top = 300;
            fvpn.Show();
        }
    }
}
