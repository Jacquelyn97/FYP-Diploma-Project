using System;
using System.Windows.Forms;

namespace Final
{
    public partial class Scan : UserControl
    {
        public Scan()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "      Simple")
            {
                MD5Scanner scanner = new MD5Scanner();
                scanner.StartPosition = FormStartPosition.Manual;
                scanner.Left = 590;
                scanner.Top = 400;
                scanner.Show();
            }
            else if (comboBox1.Text == "   Advanced")
            {
                VirusTotal virusTotal = new VirusTotal();
                virusTotal.StartPosition = FormStartPosition.Manual;
                virusTotal.Left = 420;
                virusTotal.Top = 300;
                virusTotal.Show();
            }
        }
    }
}
