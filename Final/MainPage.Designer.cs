namespace Final
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.top = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.maximize = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.txtTitle = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.homeTimer = new System.Windows.Forms.Timer(this.components);
            this.toolTimer = new System.Windows.Forms.Timer(this.components);
            this.settingTimer = new System.Windows.Forms.Timer(this.components);
            this.homeContainer = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnContact = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnKnowledge = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.menuLogo = new System.Windows.Forms.PictureBox();
            this.toolContainer = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnVPN = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnScan = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnPerformance = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnTools = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.settingContainer = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.sideBar = new System.Windows.Forms.Panel();
            this.menu1 = new Final.Menu();
            this.knowledge1 = new Final.Knowledge();
            this.contact1 = new Final.Contact();
            this.performance1 = new Final.Performance();
            this.scan1 = new Final.Scan();
            this.vpn1 = new Final.VPN();
            this.dragControl1 = new testing.DragControl();
            this.top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.homeContainer.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuLogo)).BeginInit();
            this.toolContainer.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel5.SuspendLayout();
            this.settingContainer.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel6.SuspendLayout();
            this.sideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.White;
            this.top.Controls.Add(this.minimize);
            this.top.Controls.Add(this.maximize);
            this.top.Controls.Add(this.close);
            this.top.Controls.Add(this.txtTitle);
            this.top.Controls.Add(this.logo);
            this.top.Dock = System.Windows.Forms.DockStyle.Top;
            this.top.Location = new System.Drawing.Point(0, 0);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(1276, 49);
            this.top.TabIndex = 2;
            // 
            // minimize
            // 
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.Location = new System.Drawing.Point(1174, 14);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(26, 26);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize.TabIndex = 4;
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // maximize
            // 
            this.maximize.Cursor = System.Windows.Forms.Cursors.No;
            this.maximize.Image = ((System.Drawing.Image)(resources.GetObject("maximize.Image")));
            this.maximize.Location = new System.Drawing.Point(1208, 14);
            this.maximize.Name = "maximize";
            this.maximize.Size = new System.Drawing.Size(26, 26);
            this.maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximize.TabIndex = 3;
            this.maximize.TabStop = false;
            // 
            // close
            // 
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(1241, 14);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(26, 26);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 2;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Font = new System.Drawing.Font("Corbel", 9F);
            this.txtTitle.Location = new System.Drawing.Point(45, 14);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(106, 22);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.Text = "SafeWisdom";
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(8, 6);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(37, 36);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 12;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // homeTimer
            // 
            this.homeTimer.Interval = 12;
            this.homeTimer.Tick += new System.EventHandler(this.homeTimer_Tick);
            // 
            // toolTimer
            // 
            this.toolTimer.Interval = 12;
            this.toolTimer.Tick += new System.EventHandler(this.toolTimer_Tick);
            // 
            // settingTimer
            // 
            this.settingTimer.Interval = 12;
            this.settingTimer.Tick += new System.EventHandler(this.settingTimer_Tick);
            // 
            // homeContainer
            // 
            this.homeContainer.BackColor = System.Drawing.Color.MistyRose;
            this.homeContainer.Controls.Add(this.panel7);
            this.homeContainer.Controls.Add(this.panel2);
            this.homeContainer.Controls.Add(this.panel4);
            this.homeContainer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeContainer.Location = new System.Drawing.Point(0, 107);
            this.homeContainer.MaximumSize = new System.Drawing.Size(270, 185);
            this.homeContainer.MinimumSize = new System.Drawing.Size(270, 61);
            this.homeContainer.Name = "homeContainer";
            this.homeContainer.Size = new System.Drawing.Size(270, 61);
            this.homeContainer.TabIndex = 10;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.btnContact);
            this.panel7.Location = new System.Drawing.Point(0, 124);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(270, 61);
            this.panel7.TabIndex = 9;
            // 
            // btnContact
            // 
            this.btnContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContact.Font = new System.Drawing.Font("Corbel", 13F);
            this.btnContact.ForeColor = System.Drawing.Color.Black;
            this.btnContact.Image = ((System.Drawing.Image)(resources.GetObject("btnContact.Image")));
            this.btnContact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContact.Location = new System.Drawing.Point(-12, -5);
            this.btnContact.Name = "btnContact";
            this.btnContact.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnContact.Size = new System.Drawing.Size(287, 71);
            this.btnContact.TabIndex = 2;
            this.btnContact.Text = "             Contact";
            this.btnContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContact.UseVisualStyleBackColor = true;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnKnowledge);
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 61);
            this.panel2.TabIndex = 8;
            // 
            // btnKnowledge
            // 
            this.btnKnowledge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKnowledge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKnowledge.Font = new System.Drawing.Font("Corbel", 13F);
            this.btnKnowledge.ForeColor = System.Drawing.Color.Black;
            this.btnKnowledge.Image = ((System.Drawing.Image)(resources.GetObject("btnKnowledge.Image")));
            this.btnKnowledge.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKnowledge.Location = new System.Drawing.Point(-12, -5);
            this.btnKnowledge.Name = "btnKnowledge";
            this.btnKnowledge.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnKnowledge.Size = new System.Drawing.Size(287, 71);
            this.btnKnowledge.TabIndex = 2;
            this.btnKnowledge.Text = "             Knowledge";
            this.btnKnowledge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKnowledge.UseVisualStyleBackColor = true;
            this.btnKnowledge.Click += new System.EventHandler(this.btnKnowledge_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RosyBrown;
            this.panel4.Controls.Add(this.btnHome);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(270, 61);
            this.panel4.TabIndex = 4;
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Corbel", 13F);
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(-12, -5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(287, 71);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "             Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.Transparent;
            this.menuPanel.Controls.Add(this.menuLogo);
            this.menuPanel.Location = new System.Drawing.Point(0, 1);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(270, 61);
            this.menuPanel.TabIndex = 8;
            // 
            // menuLogo
            // 
            this.menuLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuLogo.Image = ((System.Drawing.Image)(resources.GetObject("menuLogo.Image")));
            this.menuLogo.Location = new System.Drawing.Point(29, 17);
            this.menuLogo.Name = "menuLogo";
            this.menuLogo.Size = new System.Drawing.Size(26, 26);
            this.menuLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuLogo.TabIndex = 2;
            this.menuLogo.TabStop = false;
            this.menuLogo.Click += new System.EventHandler(this.menuLogo_Click);
            // 
            // toolContainer
            // 
            this.toolContainer.BackColor = System.Drawing.Color.MistyRose;
            this.toolContainer.Controls.Add(this.panel11);
            this.toolContainer.Controls.Add(this.panel10);
            this.toolContainer.Controls.Add(this.panel9);
            this.toolContainer.Controls.Add(this.panel5);
            this.toolContainer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toolContainer.Location = new System.Drawing.Point(0, 170);
            this.toolContainer.MaximumSize = new System.Drawing.Size(270, 247);
            this.toolContainer.MinimumSize = new System.Drawing.Size(270, 61);
            this.toolContainer.Name = "toolContainer";
            this.toolContainer.Size = new System.Drawing.Size(270, 61);
            this.toolContainer.TabIndex = 8;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Transparent;
            this.panel11.Controls.Add(this.btnVPN);
            this.panel11.Location = new System.Drawing.Point(0, 186);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(270, 61);
            this.panel11.TabIndex = 6;
            // 
            // btnVPN
            // 
            this.btnVPN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVPN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVPN.Font = new System.Drawing.Font("Corbel", 13F);
            this.btnVPN.ForeColor = System.Drawing.Color.Black;
            this.btnVPN.Image = ((System.Drawing.Image)(resources.GetObject("btnVPN.Image")));
            this.btnVPN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVPN.Location = new System.Drawing.Point(-12, -5);
            this.btnVPN.Name = "btnVPN";
            this.btnVPN.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnVPN.Size = new System.Drawing.Size(297, 71);
            this.btnVPN.TabIndex = 2;
            this.btnVPN.Text = "             VPN";
            this.btnVPN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVPN.UseVisualStyleBackColor = true;
            this.btnVPN.Click += new System.EventHandler(this.btnVPN_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.Controls.Add(this.btnScan);
            this.panel10.Location = new System.Drawing.Point(0, 124);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(270, 61);
            this.panel10.TabIndex = 6;
            // 
            // btnScan
            // 
            this.btnScan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScan.Font = new System.Drawing.Font("Corbel", 13F);
            this.btnScan.ForeColor = System.Drawing.Color.Black;
            this.btnScan.Image = ((System.Drawing.Image)(resources.GetObject("btnScan.Image")));
            this.btnScan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScan.Location = new System.Drawing.Point(-12, -5);
            this.btnScan.Name = "btnScan";
            this.btnScan.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnScan.Size = new System.Drawing.Size(297, 71);
            this.btnScan.TabIndex = 2;
            this.btnScan.Text = "             Scan";
            this.btnScan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.Controls.Add(this.btnPerformance);
            this.panel9.Location = new System.Drawing.Point(0, 62);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(270, 61);
            this.panel9.TabIndex = 6;
            // 
            // btnPerformance
            // 
            this.btnPerformance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerformance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerformance.Font = new System.Drawing.Font("Corbel", 13F);
            this.btnPerformance.ForeColor = System.Drawing.Color.Black;
            this.btnPerformance.Image = ((System.Drawing.Image)(resources.GetObject("btnPerformance.Image")));
            this.btnPerformance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerformance.Location = new System.Drawing.Point(-12, -5);
            this.btnPerformance.Name = "btnPerformance";
            this.btnPerformance.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnPerformance.Size = new System.Drawing.Size(297, 71);
            this.btnPerformance.TabIndex = 2;
            this.btnPerformance.Text = "             Performance";
            this.btnPerformance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerformance.UseVisualStyleBackColor = true;
            this.btnPerformance.Click += new System.EventHandler(this.btnPerformance_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.RosyBrown;
            this.panel5.Controls.Add(this.btnTools);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(270, 61);
            this.panel5.TabIndex = 5;
            // 
            // btnTools
            // 
            this.btnTools.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTools.Font = new System.Drawing.Font("Corbel", 13F);
            this.btnTools.ForeColor = System.Drawing.Color.Black;
            this.btnTools.Image = ((System.Drawing.Image)(resources.GetObject("btnTools.Image")));
            this.btnTools.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTools.Location = new System.Drawing.Point(-12, -5);
            this.btnTools.Name = "btnTools";
            this.btnTools.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnTools.Size = new System.Drawing.Size(287, 71);
            this.btnTools.TabIndex = 2;
            this.btnTools.Text = "             Tools";
            this.btnTools.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTools.UseVisualStyleBackColor = true;
            this.btnTools.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMenu.Font = new System.Drawing.Font("Corbel", 13F);
            this.lblMenu.Location = new System.Drawing.Point(103, 15);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(75, 32);
            this.lblMenu.TabIndex = 7;
            this.lblMenu.Text = "Menu";
            this.lblMenu.Click += new System.EventHandler(this.lblMenu_Click);
            // 
            // settingContainer
            // 
            this.settingContainer.BackColor = System.Drawing.Color.MistyRose;
            this.settingContainer.Controls.Add(this.panel13);
            this.settingContainer.Controls.Add(this.panel12);
            this.settingContainer.Controls.Add(this.panel6);
            this.settingContainer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingContainer.Location = new System.Drawing.Point(0, 232);
            this.settingContainer.MaximumSize = new System.Drawing.Size(270, 185);
            this.settingContainer.MinimumSize = new System.Drawing.Size(270, 61);
            this.settingContainer.Name = "settingContainer";
            this.settingContainer.Size = new System.Drawing.Size(270, 61);
            this.settingContainer.TabIndex = 9;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Transparent;
            this.panel13.Controls.Add(this.btnUpdate);
            this.panel13.Location = new System.Drawing.Point(0, 124);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(270, 61);
            this.panel13.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Corbel", 13F);
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(-12, -5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnUpdate.Size = new System.Drawing.Size(297, 71);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "             Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Transparent;
            this.panel12.Controls.Add(this.btnLogout);
            this.panel12.Location = new System.Drawing.Point(0, 62);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(270, 61);
            this.panel12.TabIndex = 6;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Corbel", 13F);
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(-12, -5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(297, 71);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "             Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.RosyBrown;
            this.panel6.Controls.Add(this.btnSetting);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(270, 61);
            this.panel6.TabIndex = 5;
            // 
            // btnSetting
            // 
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Corbel", 13F);
            this.btnSetting.ForeColor = System.Drawing.Color.Black;
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(-12, -5);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSetting.Size = new System.Drawing.Size(297, 71);
            this.btnSetting.TabIndex = 2;
            this.btnSetting.Text = "             Setting";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.RosyBrown;
            this.sideBar.Controls.Add(this.settingContainer);
            this.sideBar.Controls.Add(this.lblMenu);
            this.sideBar.Controls.Add(this.toolContainer);
            this.sideBar.Controls.Add(this.menuPanel);
            this.sideBar.Controls.Add(this.homeContainer);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 49);
            this.sideBar.MaximumSize = new System.Drawing.Size(270, 743);
            this.sideBar.MinimumSize = new System.Drawing.Size(86, 743);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(86, 743);
            this.sideBar.TabIndex = 3;
            // 
            // menu1
            // 
            this.menu1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menu1.Location = new System.Drawing.Point(0, 49);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(1276, 742);
            this.menu1.TabIndex = 4;
            // 
            // knowledge1
            // 
            this.knowledge1.AutoScroll = true;
            this.knowledge1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.knowledge1.Location = new System.Drawing.Point(0, 49);
            this.knowledge1.Name = "knowledge1";
            this.knowledge1.Size = new System.Drawing.Size(1276, 742);
            this.knowledge1.TabIndex = 5;
            // 
            // contact1
            // 
            this.contact1.AutoScroll = true;
            this.contact1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.contact1.Location = new System.Drawing.Point(0, 49);
            this.contact1.Name = "contact1";
            this.contact1.Size = new System.Drawing.Size(1276, 742);
            this.contact1.TabIndex = 6;
            // 
            // performance1
            // 
            this.performance1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.performance1.Location = new System.Drawing.Point(0, 49);
            this.performance1.Name = "performance1";
            this.performance1.Size = new System.Drawing.Size(1276, 742);
            this.performance1.TabIndex = 7;
            // 
            // scan1
            // 
            this.scan1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.scan1.Location = new System.Drawing.Point(0, 49);
            this.scan1.Name = "scan1";
            this.scan1.Size = new System.Drawing.Size(1276, 742);
            this.scan1.TabIndex = 8;
            // 
            // vpn1
            // 
            this.vpn1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.vpn1.Location = new System.Drawing.Point(0, 49);
            this.vpn1.Name = "vpn1";
            this.vpn1.Size = new System.Drawing.Size(1276, 742);
            this.vpn1.TabIndex = 9;
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.top;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 792);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.top);
            this.Controls.Add(this.menu1);
            this.Controls.Add(this.knowledge1);
            this.Controls.Add(this.contact1);
            this.Controls.Add(this.performance1);
            this.Controls.Add(this.scan1);
            this.Controls.Add(this.vpn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.top.ResumeLayout(false);
            this.top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.homeContainer.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuLogo)).EndInit();
            this.toolContainer.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.settingContainer.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.sideBar.ResumeLayout(false);
            this.sideBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.PictureBox maximize;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Timer homeTimer;
        private System.Windows.Forms.Timer toolTimer;
        private System.Windows.Forms.Timer settingTimer;
        private Menu menu1;
        private Knowledge knowledge1;
        private Contact contact1;
        private testing.DragControl dragControl1;
        private Performance performance1;
        private System.Windows.Forms.Panel homeContainer;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnKnowledge;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.PictureBox menuLogo;
        private System.Windows.Forms.Panel toolContainer;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnVPN;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnPerformance;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnTools;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Panel settingContainer;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Panel sideBar;
        private Scan scan1;
        private VPN vpn1;
    }
}