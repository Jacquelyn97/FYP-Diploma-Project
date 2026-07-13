namespace Final
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.startSide = new System.Windows.Forms.Panel();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.emailPanel = new System.Windows.Forms.Panel();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.usernamePanel = new System.Windows.Forms.Panel();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.confirmPanel = new System.Windows.Forms.Panel();
            this.textBoxConfirm = new System.Windows.Forms.TextBox();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.dragControl1 = new testing.DragControl();
            this.dragControl2 = new testing.DragControl();
            this.startSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.emailPanel.SuspendLayout();
            this.usernamePanel.SuspendLayout();
            this.confirmPanel.SuspendLayout();
            this.passwordPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // startSide
            // 
            this.startSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(226)))), ((int)(((byte)(219)))));
            this.startSide.Controls.Add(this.lbl3);
            this.startSide.Controls.Add(this.lbl2);
            this.startSide.Controls.Add(this.lbl1);
            this.startSide.Controls.Add(this.pictureBox1);
            this.startSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.startSide.Location = new System.Drawing.Point(0, 0);
            this.startSide.Name = "startSide";
            this.startSide.Size = new System.Drawing.Size(539, 589);
            this.startSide.TabIndex = 1;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl3.Font = new System.Drawing.Font("Corbel", 9.5F);
            this.lbl3.ForeColor = System.Drawing.Color.Black;
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
            this.lbl2.Font = new System.Drawing.Font("Corbel", 16F);
            this.lbl2.ForeColor = System.Drawing.Color.White;
            this.lbl2.Location = new System.Drawing.Point(247, 430);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(257, 39);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Start your journey";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl1.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold);
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(247, 479);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(97, 39);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "today";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 530);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl4.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold);
            this.lbl4.ForeColor = System.Drawing.Color.Black;
            this.lbl4.Location = new System.Drawing.Point(587, 95);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(213, 37);
            this.lbl4.TabIndex = 4;
            this.lbl4.Text = "Create Account";
            // 
            // emailPanel
            // 
            this.emailPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.emailPanel.Controls.Add(this.textBoxEmail);
            this.emailPanel.Location = new System.Drawing.Point(594, 227);
            this.emailPanel.Name = "emailPanel";
            this.emailPanel.Size = new System.Drawing.Size(355, 42);
            this.emailPanel.TabIndex = 10;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Corbel", 11F);
            this.textBoxEmail.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxEmail.Location = new System.Drawing.Point(14, 8);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(338, 27);
            this.textBoxEmail.TabIndex = 4;
            this.textBoxEmail.Text = "Email";
            this.textBoxEmail.Enter += new System.EventHandler(this.textBoxEmail_Enter);
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            // 
            // usernamePanel
            // 
            this.usernamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.usernamePanel.Controls.Add(this.textBoxUsername);
            this.usernamePanel.Location = new System.Drawing.Point(594, 167);
            this.usernamePanel.Name = "usernamePanel";
            this.usernamePanel.Size = new System.Drawing.Size(355, 42);
            this.usernamePanel.TabIndex = 9;
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
            // confirmPanel
            // 
            this.confirmPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.confirmPanel.Controls.Add(this.textBoxConfirm);
            this.confirmPanel.Location = new System.Drawing.Point(594, 349);
            this.confirmPanel.Name = "confirmPanel";
            this.confirmPanel.Size = new System.Drawing.Size(355, 42);
            this.confirmPanel.TabIndex = 12;
            // 
            // textBoxConfirm
            // 
            this.textBoxConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConfirm.Font = new System.Drawing.Font("Corbel", 11F);
            this.textBoxConfirm.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxConfirm.Location = new System.Drawing.Point(14, 8);
            this.textBoxConfirm.Name = "textBoxConfirm";
            this.textBoxConfirm.Size = new System.Drawing.Size(338, 27);
            this.textBoxConfirm.TabIndex = 4;
            this.textBoxConfirm.Text = "Confirm Password";
            this.textBoxConfirm.Enter += new System.EventHandler(this.textBoxConfirm_Enter);
            this.textBoxConfirm.Leave += new System.EventHandler(this.textBoxConfirm_Leave);
            // 
            // passwordPanel
            // 
            this.passwordPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.passwordPanel.Controls.Add(this.textBoxPassword);
            this.passwordPanel.Location = new System.Drawing.Point(594, 289);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Size = new System.Drawing.Size(355, 42);
            this.passwordPanel.TabIndex = 11;
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
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Corbel", 10F);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(674, 434);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(196, 49);
            this.btnRegister.TabIndex = 13;
            this.btnRegister.Text = "Sign Up";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.BackColor = System.Drawing.Color.Transparent;
            this.login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Font = new System.Drawing.Font("Corbel", 9.5F);
            this.login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(182)))));
            this.login.Location = new System.Drawing.Point(855, 503);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(54, 23);
            this.login.TabIndex = 15;
            this.login.Text = "Login";
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.BackColor = System.Drawing.Color.Transparent;
            this.lbl5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl5.Font = new System.Drawing.Font("Corbel", 9.5F);
            this.lbl5.Location = new System.Drawing.Point(637, 503);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(207, 23);
            this.lbl5.TabIndex = 14;
            this.lbl5.Text = "Already have an account?";
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this;
            // 
            // dragControl2
            // 
            this.dragControl2.SelectControl = this.startSide;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(997, 589);
            this.Controls.Add(this.login);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.confirmPanel);
            this.Controls.Add(this.emailPanel);
            this.Controls.Add(this.passwordPanel);
            this.Controls.Add(this.usernamePanel);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.startSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.startSide.ResumeLayout(false);
            this.startSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.emailPanel.ResumeLayout(false);
            this.emailPanel.PerformLayout();
            this.usernamePanel.ResumeLayout(false);
            this.usernamePanel.PerformLayout();
            this.confirmPanel.ResumeLayout(false);
            this.confirmPanel.PerformLayout();
            this.passwordPanel.ResumeLayout(false);
            this.passwordPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel startSide;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private testing.DragControl dragControl1;
        private testing.DragControl dragControl2;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Panel confirmPanel;
        private System.Windows.Forms.TextBox textBoxConfirm;
        private System.Windows.Forms.Panel emailPanel;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Panel passwordPanel;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Panel usernamePanel;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label lbl5;
    }
}