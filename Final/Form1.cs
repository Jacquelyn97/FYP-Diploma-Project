using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Final
{
    public partial class Form1 : KryptonForm
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse
        );

        private void Form1_Load(object sender, EventArgs e)
        {
            signIn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, signIn.Width, signIn.Height, 30, 30));
            signUp.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, signUp.Width, signUp.Height, 30, 30));
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void txtBtnSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.StartPosition = FormStartPosition.Manual;
            lf.Left = 400;
            lf.Top = 300;
            lf.Show();
        }

        private void txtBtnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm rf = new RegisterForm();
            rf.StartPosition = FormStartPosition.Manual;
            rf.Left = 400;
            rf.Top = 300;
            rf.Show();
        }
    }
}
