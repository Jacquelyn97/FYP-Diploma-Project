using System;
using System.Globalization;
using System.Windows.Forms;

namespace Final
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            DTtimer.Start();
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy", CultureInfo.CreateSpecificCulture("en-US"));
        }

        private void DTtimer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            DTtimer.Start();
        }
    }
}
