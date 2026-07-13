using System;

namespace Final
{
    public partial class Usage : MetroFramework.Forms.MetroForm
    {
        public Usage()
        {
            InitializeComponent();
        }

        private void Usage_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float fcpu = pCPU.NextValue();
            float fram = pRAM.NextValue();
            float fdisk = pDISK.NextValue();

            metroProgressBar1.Value = (int)fcpu;
            metroProgressBar2.Value = (int)fram;
            metroProgressBar3.Value = (int)fdisk;

            lblCPU.Text = string.Format("{0:0.00}%", fcpu);
            lblRAM.Text = string.Format("{0:0.00}%", fram);
            lblDISK.Text = string.Format("{0:0.00}%", fdisk);

            chart1.Series["CPU"].Points.AddY(fcpu);
            chart1.Series["RAM"].Points.AddY(fram);
            chart1.Series["DISK"].Points.AddY(fdisk);
        }
    }
}
