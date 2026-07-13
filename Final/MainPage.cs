using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Final
{
    public partial class MainPage : KryptonForm
    {
        bool sidebarExpand;
        bool homeCollapse;
        bool toolCollapse;
        bool settingCollapse;

        public MainPage()
        {
            InitializeComponent();
            menu1.Visible = true;
            knowledge1.Visible = false;
            contact1.Visible = false;
            performance1.Visible = false;
            scan1.Visible = false;
            vpn1.Visible = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #region sidebar
        private void menuLogo_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sideBar.Width -= 10;
                if (sideBar.Width == sideBar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sideBar.Width += 10;
                if (sideBar.Width == sideBar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }
        #endregion

        #region home
        private void btnHome_Click(object sender, EventArgs e)
        {
            homeTimer.Start();
        }

        private void homeTimer_Tick(object sender, EventArgs e)
        {
            if (homeCollapse)
            {
                homeContainer.Height += 10;
                if (homeContainer.Height == homeContainer.MaximumSize.Height)
                {
                    if (toolContainer.Height == toolContainer.MaximumSize.Height)
                    {
                        toolContainer.Location = new Point(0, 190);
                        settingContainer.Location = new Point(0, 350);
                        homeCollapse = false;
                        homeTimer.Stop();
                    }
                    else if (toolContainer.Height == toolContainer.MinimumSize.Height)
                    {
                        toolContainer.Location = new Point(0, 190);
                        settingContainer.Location = new Point(0, 230);
                        homeCollapse = false;
                        homeTimer.Stop();
                    }
                }
            }
            else
            {
                homeContainer.Height -= 10;
                if (homeContainer.Height == homeContainer.MinimumSize.Height)
                {
                    if (toolContainer.Height == toolContainer.MaximumSize.Height)
                    {
                        homeCollapse = true;
                        homeTimer.Stop();
                        toolContainer.Location = new Point(0, 110);
                        settingContainer.Location = new Point(0, 271);
                    }
                    else if (toolContainer.Height == toolContainer.MinimumSize.Height)
                    {
                        homeCollapse = true;
                        homeTimer.Stop();
                        toolContainer.Location = new Point(0, 110);
                        settingContainer.Location = new Point(0, 151);
                    }
                }
            }
        }
        #endregion

        #region tool
        private void btnTools_Click(object sender, EventArgs e)
        {
            toolTimer.Start();
        }

        private void toolTimer_Tick(object sender, EventArgs e)
        {
            if (toolCollapse)
            {
                toolContainer.Height += 10;
                if (toolContainer.Height == toolContainer.MaximumSize.Height)
                {
                    if (homeContainer.Height == homeContainer.MaximumSize.Height)
                    {
                        settingContainer.Location = new Point(0, 350);
                        toolCollapse = false;
                        toolTimer.Stop();
                    }
                    else if (homeContainer.Height == homeContainer.MinimumSize.Height)
                    {
                        settingContainer.Location = new Point(0, 271);
                        toolCollapse = false;
                        toolTimer.Stop();
                    }
                }
            }
            else
            {
                toolContainer.Height -= 10;
                if (toolContainer.Height == toolContainer.MinimumSize.Height)
                {
                    if (homeContainer.Height == homeContainer.MaximumSize.Height)
                    {
                        toolCollapse = true;
                        toolTimer.Stop();
                        settingContainer.Location = new Point(0, 230);
                    }
                    else if (homeContainer.Height == homeContainer.MinimumSize.Height)
                    {
                        toolCollapse = true;
                        toolTimer.Stop();
                        settingContainer.Location = new Point(0, 151);
                    }
                }
            }
        }
        #endregion

        #region setting
        private void btnSetting_Click(object sender, EventArgs e)
        {
            settingTimer.Start();
        }

        private void settingTimer_Tick(object sender, EventArgs e)
        {
            if (settingCollapse)
            {
                settingContainer.Height += 10;
                if (settingContainer.Height == settingContainer.MaximumSize.Height)
                {
                    settingCollapse = false;
                    settingTimer.Stop();
                }
            }
            else
            {
                settingContainer.Height -= 10;
                if (settingContainer.Height == settingContainer.MinimumSize.Height)
                {
                    settingCollapse = true;
                    settingTimer.Stop();
                }
            }
        }
        #endregion

        private void lblMenu_Click(object sender, EventArgs e)
        {
            menu1.Visible = true;
            knowledge1.Visible = false;
            contact1.Visible = false;
            performance1.Visible = false;
            scan1.Visible = false;
            vpn1.Visible = false;
        }

        private void btnKnowledge_Click(object sender, EventArgs e)
        {
            menu1.Visible = false;
            knowledge1.Visible = true;
            contact1.Visible = false;
            performance1.Visible = false;
            scan1.Visible = false;
            vpn1.Visible = false;
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            menu1.Visible = false;
            knowledge1.Visible = false;
            contact1.Visible = true;
            performance1.Visible = false;
            scan1.Visible = false;
            vpn1.Visible = false;
        }

        private void btnPerformance_Click(object sender, EventArgs e)
        {
            menu1.Visible = false;
            knowledge1.Visible = false;
            contact1.Visible = false;
            performance1.Visible = true;
            scan1.Visible = false;
            vpn1.Visible = false;
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            menu1.Visible = false;
            knowledge1.Visible = false;
            contact1.Visible = false;
            performance1.Visible = false;
            scan1.Visible = true;
            vpn1.Visible = false;
        }

        private void btnVPN_Click(object sender, EventArgs e)
        {
            menu1.Visible = false;
            knowledge1.Visible = false;
            contact1.Visible = false;
            performance1.Visible = false;
            scan1.Visible = false;
            vpn1.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout lg = new Logout();
            lg.StartPosition = FormStartPosition.Manual;
            lg.Left = 590;
            lg.Top = 400;
            lg.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update ud = new Update();
            ud.StartPosition = FormStartPosition.Manual;
            ud.Left = 590;
            ud.Top = 400;
            ud.Show();
        }
    }
}
