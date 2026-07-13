using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Final
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Program Files (x86)\\ChaiYing\\SafeWisdom\\updater.exe");
        }
    }
}
