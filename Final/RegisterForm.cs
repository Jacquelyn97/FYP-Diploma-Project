using ComponentFactory.Krypton.Toolkit;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Final
{
    public partial class RegisterForm : KryptonForm
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

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            usernamePanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, usernamePanel.Width, usernamePanel.Height, 18, 18));
            emailPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, emailPanel.Width, emailPanel.Height, 18, 18));
            passwordPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, passwordPanel.Width, passwordPanel.Height, 18, 18));
            confirmPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, confirmPanel.Width, confirmPanel.Height, 18, 18));
            btnRegister.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnRegister.Width, btnRegister.Height, 30, 30));
        }

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void lbl3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void login_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.StartPosition = FormStartPosition.Manual;
            lf.Left = 400;
            lf.Top = 300;
            lf.Show();
        }

        #region textBoxEnter and Leave
        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            string userN = textBoxUsername.Text;
            if (userN.Trim().Equals("Username"))
            {
                textBoxUsername.Text = "";
                textBoxUsername.ForeColor = Color.Black;
            }
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            string userN = textBoxUsername.Text;
            if (userN.Trim().Equals("Username") || userN.Trim().Equals(""))
            {
                textBoxUsername.Text = "Username";
                textBoxUsername.ForeColor = Color.DarkGray;
            }
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            string mail = textBoxEmail.Text;
            if (mail.Trim().Equals("Email"))
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            string mail = textBoxEmail.Text;
            if (mail.Trim().Equals("Email") || mail.Trim().Equals(""))
            {
                textBoxEmail.Text = "Email";
                textBoxEmail.ForeColor = Color.DarkGray;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            string pwd = textBoxPassword.Text;
            if (pwd.Trim().Equals("Password"))
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.Black;
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            string pwd = textBoxPassword.Text;
            if (pwd.Trim().Equals("Password") || pwd.Trim().Equals(""))
            {
                textBoxPassword.Text = "Password";
                textBoxPassword.ForeColor = Color.DarkGray;
                textBoxPassword.UseSystemPasswordChar = false;
            }
        }

        private void textBoxConfirm_Enter(object sender, EventArgs e)
        {
            string confirmP = textBoxConfirm.Text;
            if (confirmP.Trim().Equals("Confirm Password"))
            {
                textBoxConfirm.Text = "";
                textBoxConfirm.ForeColor = Color.Black;
                textBoxConfirm.UseSystemPasswordChar = true;
            }
        }

        private void textBoxConfirm_Leave(object sender, EventArgs e)
        {
            string confirmP = textBoxConfirm.Text;
            if (confirmP.Trim().Equals("Confirm Password") || confirmP.Trim().Equals("Password") || confirmP.Trim().Equals(""))
            {
                textBoxConfirm.Text = "Confirm Password";
                textBoxConfirm.ForeColor = Color.DarkGray;
                textBoxConfirm.UseSystemPasswordChar = false;
            }
        }
        #endregion

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SQL_Database db = new SQL_Database();

            MySqlCommand command = new MySqlCommand("INSERT INTO user (username, password, email) VALUES (@user, @pass, @mail)", db.GetConnection());

            command.Parameters.Add("@user", MySqlDbType.VarChar).Value = textBoxUsername.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPassword.Text;
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = textBoxEmail.Text;

            db.openConnection();

            if (!checkTextBoxesValues())
            {
                if (textBoxPassword.Text.Equals(textBoxConfirm.Text))
                {
                    if (checkUsername())
                    {
                        MessageBox.Show("This username already exists, create another username", "Duplicate Username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else if (checkEmail())
                    {
                        MessageBox.Show("This email already exists", "Duplicate Email", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Successful! Can login now", "Account Established", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Invaild", "Something Wrong", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Make sure password are same", "Password Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Enter Your Information", "Empty Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            db.closeConnection();
        }

        public Boolean checkUsername()
        {
            SQL_Database db = new SQL_Database();

            String usr = textBoxUsername.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM user WHERE username = @user", db.GetConnection());

            command.Parameters.Add("@user", MySqlDbType.VarChar).Value = usr;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean checkEmail()
        {
            SQL_Database db = new SQL_Database();

            String email = textBoxEmail.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM user WHERE email = @mail", db.GetConnection());

            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = email;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean checkTextBoxesValues()
        {
            string usr = textBoxUsername.Text;
            string pwd = textBoxPassword.Text;
            string mail = textBoxEmail.Text;
            if (usr.Equals("") || pwd.Equals("") || mail.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
