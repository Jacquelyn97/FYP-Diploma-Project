namespace Final
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.dragControl1 = new testing.DragControl();
            this.welcomeSide = new System.Windows.Forms.Panel();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dragControl2 = new testing.DragControl();
            this.lbl4 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.usernamePanel = new System.Windows.Forms.Panel();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.createAccount = new System.Windows.Forms.Label();
            this.welcomeSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.usernamePanel.SuspendLayout();
            this.passwordPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this;
            // 
            // welcomeSide
            // 
            this.welcomeSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(104)))), ((int)(((byte)(203)))));
            this.welcomeSide.Controls.Add(this.lbl3);
            this.welcomeSide.Controls.Add(this.lbl2);
            this.welcomeSide.Controls.Add(this.lbl1);
            this.welcomeSide.Controls.Add(this.pictureBox1);
            this.welcomeSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.welcomeSide.Location = new System.Drawing.Point(0, 0);
            this.welcomeSide.Name = "welcomeSide";
            this.welcomeSide.Size = new System.Drawing.Size(554, 589);
            this.welcomeSide.TabIndex = 0;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl3.Font = new System.Drawing.Font("Corbel", 9.5F);
            this.lbl3.ForeColor = System.Drawing.Color.White;
            this.lbl3.Location = new System.Drawing.Point(26, 20);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(61, 23);
            this.lbl3.TabIndex = 1;
            this.lbl3.Text = "< Back";
            this.lbl3.Click += new System.EventHandler(this.lbl3_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl2.Font = new System.Drawing.Font("Corbel", 9.5F);
            this.lbl2.ForeColor = System.Drawing.Color.White;
            this.lbl2.Location = new System.Drawing.Point(77, 500);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(410, 23);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "You can sign into access with your existing account.";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl1.Font = new System.Drawing.Font("Corbel", 19F, System.Drawing.FontStyle.Bold);
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(72, 435);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(272, 46);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Welcome Back!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(463, 434);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dragControl2
            // 
            this.dragControl2.SelectControl = this.welcomeSide;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl4.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold);
            this.lbl4.ForeColor = System.Drawing.Color.Black;
            this.lbl4.Location = new System.Drawing.Point(589, 98);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(106, 37);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "Sign In";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Font = new System.Drawing.Font("Corbel", 11F);
            this.textBoxUsername.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxUsername.Location = new System.Drawing.Point(14, 8);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(338, 27);
            this.textBoxUsername.TabIndex = 4;
            this.textBoxUsername.Text = "Username";
            this.textBoxUsername.Enter += new System.EventHandler(this.textBoxUsername_Enter);
            this.textBoxUsername.Leave += new System.EventHandler(this.textBoxUsername_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(78)))), ((int)(((byte)(194)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Corbel", 10F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(677, 372);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(196, 49);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // usernamePanel
            // 
            this.usernamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.usernamePanel.Controls.Add(this.textBoxUsername);
            this.usernamePanel.Location = new System.Drawing.Point(596, 192);
            this.usernamePanel.Name = "usernamePanel";
            this.usernamePanel.Size = new System.Drawing.Size(355, 42);
            this.usernamePanel.TabIndex = 7;
            // 
            // passwordPanel
            // 
            this.passwordPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.passwordPanel.Controls.Add(this.textBoxPassword);
            this.passwordPanel.Location = new System.Drawing.Point(596, 262);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Size = new System.Drawing.Size(355, 42);
            this.passwordPanel.TabIndex = 8;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Corbel", 11F);
            this.textBoxPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxPassword.Location = new System.Drawing.Point(14, 8);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(338, 27);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.Text = "Password";
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.BackColor = System.Drawing.Color.Transparent;
            this.lbl5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl5.Font = new System.Drawing.Font("Corbel", 9.5F);
            this.lbl5.Location = new System.Drawing.Point(620, 443);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(169, 23);
            this.lbl5.TabIndex = 9;
            this.lbl5.Text = "Don’t have account?";
            // 
            // createAccount
            // 
            this.createAccount.AutoSize = true;
            this.createAccount.BackColor = System.Drawing.Color.Transparent;
            this.createAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createAccount.Font = new System.Drawing.Font("Corbel", 9.5F);
            this.createAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(182)))));
            this.createAccount.Location = new System.Drawing.Point(798, 443);
            this.createAccount.Name = "createAccount";
            this.createAccount.Size = new System.Drawing.Size(127, 23);
            this.createAccount.TabIndex = 10;
            this.createAccount.Text = "Create account";
            this.createAccount.Click += new System.EventHandler(this.createAccount_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(997, 589);
            this.Controls.Add(this.createAccount);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.passwordPanel);
            this.Controls.Add(this.usernamePanel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.welcomeSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.welcomeSide.ResumeLayout(false);
            this.welcomeSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.usernamePanel.ResumeLayout(false);
            this.usernamePanel.PerformLayout();
            this.passwordPanel.ResumeLayout(false);
            this.passwordPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private testing.DragControl dragControl1;
        private System.Windows.Forms.Panel welcomeSide;
        private testing.DragControl dragControl2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel usernamePanel;
        private System.Windows.Forms.Panel passwordPanel;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label createAccount;
        private System.Windows.Forms.Label lbl5;
    }
}