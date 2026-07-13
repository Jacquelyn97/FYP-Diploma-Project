namespace Final
{
    partial class FreeVPN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FreeVPN));
            this.top = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.txtTitle = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.link = new System.Windows.Forms.LinkLabel();
            this.dragControl1 = new testing.DragControl();
            this.flatCombo1 = new Final.FlatCombo();
            this.lbl10 = new System.Windows.Forms.Label();
            this.top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.White;
            this.top.Controls.Add(this.minimize);
            this.top.Controls.Add(this.close);
            this.top.Controls.Add(this.txtTitle);
            this.top.Dock = System.Windows.Forms.DockStyle.Top;
            this.top.Location = new System.Drawing.Point(0, 0);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(558, 49);
            this.top.TabIndex = 0;
            // 
            // minimize
            // 
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.Location = new System.Drawing.Point(485, 12);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(26, 26);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize.TabIndex = 12;
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // close
            // 
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(518, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(26, 26);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 11;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtTitle.Font = new System.Drawing.Font("Corbel", 9F);
            this.txtTitle.Location = new System.Drawing.Point(14, 13);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(44, 22);
            this.txtTitle.TabIndex = 9;
            this.txtTitle.Text = "VPN";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl1.Font = new System.Drawing.Font("Corbel", 10F);
            this.lbl1.Location = new System.Drawing.Point(48, 79);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(448, 24);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "The following username and password can be tested";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl2.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold);
            this.lbl2.Location = new System.Drawing.Point(48, 110);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(54, 24);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "host:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl3.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold);
            this.lbl3.Location = new System.Drawing.Point(48, 172);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(100, 24);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "username:";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl4.Font = new System.Drawing.Font("Corbel", 10F);
            this.lbl4.Location = new System.Drawing.Point(48, 203);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(84, 24);
            this.lbl4.TabIndex = 5;
            this.lbl4.Text = "vpnbook";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl5.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold);
            this.lbl5.Location = new System.Drawing.Point(48, 234);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(97, 24);
            this.lbl5.TabIndex = 6;
            this.lbl5.Text = "password:";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl6.Font = new System.Drawing.Font("Corbel", 10F);
            this.lbl6.Location = new System.Drawing.Point(48, 265);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(81, 24);
            this.lbl6.TabIndex = 7;
            this.lbl6.Text = "3ev7r8m";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHost.Font = new System.Drawing.Font("Corbel", 10F);
            this.lblHost.Location = new System.Drawing.Point(24, 324);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(49, 24);
            this.lblHost.TabIndex = 8;
            this.lblHost.Text = "Host";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUsername.Font = new System.Drawing.Font("Corbel", 10F);
            this.lblUsername.Location = new System.Drawing.Point(24, 375);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(96, 24);
            this.lblUsername.TabIndex = 9;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPassword.Font = new System.Drawing.Font("Corbel", 10F);
            this.lblPassword.Location = new System.Drawing.Point(24, 426);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(90, 24);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password";
            // 
            // txtHost
            // 
            this.txtHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHost.Location = new System.Drawing.Point(162, 324);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(367, 26);
            this.txtHost.TabIndex = 11;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Location = new System.Drawing.Point(162, 375);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(367, 26);
            this.txtUsername.TabIndex = 12;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(162, 426);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(367, 26);
            this.txtPassword.TabIndex = 13;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Corbel", 9F);
            this.btnConnect.Location = new System.Drawing.Point(136, 495);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(112, 35);
            this.btnConnect.TabIndex = 14;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnDisconnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisconnect.Font = new System.Drawing.Font("Corbel", 9F);
            this.btnDisconnect.Location = new System.Drawing.Point(296, 495);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(112, 35);
            this.btnDisconnect.TabIndex = 15;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl8.Font = new System.Drawing.Font("Corbel", 9F);
            this.lbl8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl8.Location = new System.Drawing.Point(188, 241);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(284, 22);
            this.lbl8.TabIndex = 17;
            this.lbl8.Text = "*password would change, check the";
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl9.Font = new System.Drawing.Font("Corbel", 9F);
            this.lbl9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl9.Location = new System.Drawing.Point(188, 263);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(296, 22);
            this.lbl9.TabIndex = 18;
            this.lbl9.Text = "   password in the \"                           \" tab";
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.BackColor = System.Drawing.Color.Transparent;
            this.link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link.Font = new System.Drawing.Font("Corbel", 8F);
            this.link.LinkColor = System.Drawing.SystemColors.Highlight;
            this.link.Location = new System.Drawing.Point(326, 265);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(76, 19);
            this.link.TabIndex = 19;
            this.link.TabStop = true;
            this.link.Text = "OpenVPN";
            this.link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.top;
            // 
            // flatCombo1
            // 
            this.flatCombo1.BackColor = System.Drawing.Color.White;
            this.flatCombo1.BorderColor = System.Drawing.Color.BlueViolet;
            this.flatCombo1.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatCombo1.FormattingEnabled = true;
            this.flatCombo1.Items.AddRange(new object[] {
            "(selection)",
            "us1.vpnbook.com",
            "us2.vpnbook.com"});
            this.flatCombo1.Location = new System.Drawing.Point(52, 137);
            this.flatCombo1.Name = "flatCombo1";
            this.flatCombo1.Size = new System.Drawing.Size(205, 32);
            this.flatCombo1.TabIndex = 20;
            this.flatCombo1.Text = "(selection)";
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl10.Font = new System.Drawing.Font("Corbel", 9F);
            this.lbl10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl10.Location = new System.Drawing.Point(43, 542);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(471, 22);
            this.lbl10.TabIndex = 21;
            this.lbl10.Text = "Suggestion: Open the VPN window again after using the VPN";
            // 
            // FreeVPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(558, 573);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.flatCombo1);
            this.Controls.Add(this.link);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblHost);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FreeVPN";
            this.Text = "FreeVPN";
            this.top.ResumeLayout(false);
            this.top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Label lbl1;
        private testing.DragControl dragControl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.LinkLabel link;
        private FlatCombo flatCombo1;
        private System.Windows.Forms.Label lbl10;
    }
}