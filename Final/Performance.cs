using System;
using System.Windows.Forms;

namespace Final
{
    public partial class Performance : UserControl
    {
        public Performance()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Usage u = new Usage();
            u.Show();
        }
    }
}
