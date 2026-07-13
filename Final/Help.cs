using System;
using System.Windows.Forms;

namespace Final
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
