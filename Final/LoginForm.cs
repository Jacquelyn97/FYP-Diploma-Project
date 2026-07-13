using ComponentFactory.Krypton.Toolkit;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Final
{
    public partial class LoginForm : KryptonForm
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

        private void LoginForm_Load(object sender, EventArgs e)
        {
            usernamePanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, usernamePanel.Width, usernamePanel.Height, 18, 18));
            passwordPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, passwordPanel.Width, passwordPanel.Height, 18, 18));
            btnLogin.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnLogin.Width, btnLogin.Height, 30, 30));
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void lbl3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm rf = new RegisterForm();
            rf.StartPosition = FormStartPosition.Manual;
            rf.Left = 400;
            rf.Top = 300;
            rf.Show();
        }

        #region textBoxEnter and Leave
        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            string userN = textBoxUsername.Text;
            if (userN.Equals("Username"))
            {
                textBoxUsername.Text = "";
                textBoxUsername.ForeColor = Color.Black;
            }
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            string userN = textBoxUsername.Text;
            if (userN.Equals(""))
            {
                textBoxUsername.Text = "Username";
                textBoxUsername.ForeColor = Color.DarkGray;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            string pwd = textBoxPassword.Text;
            if (pwd.Equals("Password"))
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.Black;
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            string pwd = textBoxPassword.Text;
            if (pwd.Equals(""))
            {
                textBoxPassword.Text = "Password";
                textBoxPassword.ForeColor = Color.DarkGray;
                textBoxPassword.UseSystemPasswordChar = false;
            }
        }
        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SQL_Database db = new SQL_Database();

            String usr = textBoxUsername.Text;
            String pwd = textBoxPassword.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM user WHERE username = @user and password = @pass", db.GetConnection());

            command.Parameters.Add("@user", MySqlDbType.VarChar).Value = usr;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pwd;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                MainPage mp = new MainPage();
                mp.StartPosition = FormStartPosition.Manual;
                mp.Left = 300;
                mp.Top = 220;
                mp.Show();

                MessageBox.Show("Welcome back, " + usr, "Welcome Page", MessageBoxButtons.OK);
            }
            else
            {
                if (usr.Trim().Equals(""))
                {
                    MessageBox.Show("Please Enter Your Username", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (pwd.Trim().Equals(""))
                {
                    MessageBox.Show("Please Enter Your Password", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
