using System;
using System.Windows.Forms;

namespace Final
{
    public partial class Logout : Form
    {
        public Logout()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
