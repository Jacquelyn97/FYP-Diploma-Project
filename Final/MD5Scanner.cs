using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Final
{
    public partial class MD5Scanner : Form
    {
        public MD5Scanner()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public string getMD5FromFile(string filePath)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filePath))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty).ToLower();
                }
            }
        }

        private void browserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Textfiles | *.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbMD5.Text = getMD5FromFile(ofd.FileName);
                tbFilePath.Text = Path.GetFileName(ofd.FileName);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var md5Signatures = File.ReadAllLines("MD5Base.txt");
            if (md5Signatures.Contains(tbMD5.Text))
            {
                lblStatus.Text = "Infected !";
                lblStatus.ForeColor = Color.Red;
            }
            else if (tbFilePath.Text.Equals("") || tbMD5.Text.Equals(""))
            {
                MessageBox.Show("Please select file", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblStatus.Text = "Clean !";
                lblStatus.ForeColor = Color.Green;
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.StartPosition = FormStartPosition.Manual;
            h.Left = 540;
            h.Top = 350;
            h.Show();
        }
    }
}
