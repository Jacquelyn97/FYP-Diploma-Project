using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class VirusTotal : Form
    {
        public VirusTotal()
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

        private void VirusTotal_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
        private async Task initizated()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }
        public async void InitBrowser()
        {
            await initizated();
            webView21.CoreWebView2.Navigate("https://www.virustotal.com/gui/home/upload");
        }
    }
}
