namespace Final
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.top = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.maximize = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.txtTitle = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.gradientPanel1 = new Final.GradientPanel();
            this.mainPicture = new System.Windows.Forms.PictureBox();
            this.signUp = new Final.GradientPanel();
            this.txtBtnSignUp = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.signIn = new Final.GradientPanel();
            this.txtBtnSignIn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.dragControl1 = new testing.DragControl();
            this.top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicture)).BeginInit();
            this.signUp.SuspendLayout();
            this.signIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.Snow;
            this.top.Controls.Add(this.minimize);
            this.top.Controls.Add(this.maximize);
            this.top.Controls.Add(this.close);
            this.top.Controls.Add(this.txtTitle);
            this.top.Controls.Add(this.logo);
            this.top.Dock = System.Windows.Forms.DockStyle.Top;
            this.top.Location = new System.Drawing.Point(0, 0);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(1281, 49);
            this.top.TabIndex = 0;
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
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(141)))), ((int)(((byte)(198)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(209)))), ((int)(((byte)(199)))));
            this.gradientPanel1.Controls.Add(this.mainPicture);
            this.gradientPanel1.Controls.Add(this.signUp);
            this.gradientPanel1.Controls.Add(this.signIn);
            this.gradientPanel1.Controls.Add(this.lbl6);
            this.gradientPanel1.Controls.Add(this.lbl5);
            this.gradientPanel1.Controls.Add(this.lbl4);
            this.gradientPanel1.Controls.Add(this.lbl3);
            this.gradientPanel1.Controls.Add(this.lbl2);
            this.gradientPanel1.Controls.Add(this.lbl1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 50);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1281, 742);
            this.gradientPanel1.TabIndex = 1;
            // 
            // mainPicture
            // 
            this.mainPicture.BackColor = System.Drawing.Color.Transparent;
            this.mainPicture.Image = ((System.Drawing.Image)(resources.GetObject("mainPicture.Image")));
            this.mainPicture.Location = new System.Drawing.Point(567, 44);
            this.mainPicture.Name = "mainPicture";
            this.mainPicture.Size = new System.Drawing.Size(637, 642);
            this.mainPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainPicture.TabIndex = 8;
            this.mainPicture.TabStop = false;
            // 
            // signUp
            // 
            this.signUp.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(138)))));
            this.signUp.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.signUp.Controls.Add(this.txtBtnSignUp);
            this.signUp.Controls.Add(this.label7);
            this.signUp.Controls.Add(this.label8);
            this.signUp.Controls.Add(this.label9);
            this.signUp.Controls.Add(this.label10);
            this.signUp.Controls.Add(this.label11);
            this.signUp.Controls.Add(this.label12);
            this.signUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUp.Location = new System.Drawing.Point(307, 474);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(158, 52);
            this.signUp.TabIndex = 7;
            // 
            // txtBtnSignUp
            // 
            this.txtBtnSignUp.AutoSize = true;
            this.txtBtnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.txtBtnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtBtnSignUp.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.txtBtnSignUp.ForeColor = System.Drawing.Color.White;
            this.txtBtnSignUp.Location = new System.Drawing.Point(33, 10);
            this.txtBtnSignUp.Name = "txtBtnSignUp";
            this.txtBtnSignUp.Size = new System.Drawing.Size(93, 29);
            this.txtBtnSignUp.TabIndex = 9;
            this.txtBtnSignUp.Text = "Sign Up";
            this.txtBtnSignUp.Click += new System.EventHandler(this.txtBtnSignUp_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Corbel", 11F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(83, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(387, 27);
            this.label7.TabIndex = 5;
            this.label7.Text = "improvement of users\' safety knowledge.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Corbel", 11F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(83, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(338, 27);
            this.label8.TabIndex = 4;
            this.label8.Text = "and emphasize the importance and ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Corbel", 11F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(83, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(402, 27);
            this.label9.TabIndex = 3;
            this.label9.Text = "Show the wisdom and security of software ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Corbel", 8F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(222, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 19);
            this.label10.TabIndex = 2;
            this.label10.Text = "by ChaiYing";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Corbel", 16F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(81, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 39);
            this.label11.TabIndex = 1;
            this.label11.Text = "Software";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Corbel", 32F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(78, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(384, 78);
            this.label12.TabIndex = 0;
            this.label12.Text = "SafeWisdom";
            // 
            // signIn
            // 
            this.signIn.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(138)))));
            this.signIn.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.signIn.Controls.Add(this.txtBtnSignIn);
            this.signIn.Controls.Add(this.label1);
            this.signIn.Controls.Add(this.label2);
            this.signIn.Controls.Add(this.label3);
            this.signIn.Controls.Add(this.label4);
            this.signIn.Controls.Add(this.label5);
            this.signIn.Controls.Add(this.label6);
            this.signIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signIn.Location = new System.Drawing.Point(88, 474);
            this.signIn.Name = "signIn";
            this.signIn.Size = new System.Drawing.Size(158, 52);
            this.signIn.TabIndex = 6;
            // 
            // txtBtnSignIn
            // 
            this.txtBtnSignIn.AutoSize = true;
            this.txtBtnSignIn.BackColor = System.Drawing.Color.Transparent;
            this.txtBtnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtBtnSignIn.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.txtBtnSignIn.ForeColor = System.Drawing.Color.White;
            this.txtBtnSignIn.Location = new System.Drawing.Point(38, 11);
            this.txtBtnSignIn.Name = "txtBtnSignIn";
            this.txtBtnSignIn.Size = new System.Drawing.Size(84, 29);
            this.txtBtnSignIn.TabIndex = 8;
            this.txtBtnSignIn.Text = "Sign In";
            this.txtBtnSignIn.Click += new System.EventHandler(this.txtBtnSignIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Corbel", 11F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "improvement of users\' safety knowledge.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Corbel", 11F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(83, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "and emphasize the importance and ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Corbel", 11F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(83, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(402, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Show the wisdom and security of software ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Corbel", 8F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(222, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "by ChaiYing";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Corbel", 16F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(81, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 39);
            this.label5.TabIndex = 1;
            this.label5.Text = "Software";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Corbel", 32F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(78, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(384, 78);
            this.label6.TabIndex = 0;
            this.label6.Text = "SafeWisdom";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.BackColor = System.Drawing.Color.Transparent;
            this.lbl6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl6.Font = new System.Drawing.Font("Corbel", 11F);
            this.lbl6.ForeColor = System.Drawing.Color.White;
            this.lbl6.Location = new System.Drawing.Point(83, 407);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(387, 27);
            this.lbl6.TabIndex = 5;
            this.lbl6.Text = "improvement of users\' safety knowledge.";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.BackColor = System.Drawing.Color.Transparent;
            this.lbl5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl5.Font = new System.Drawing.Font("Corbel", 11F);
            this.lbl5.ForeColor = System.Drawing.Color.White;
            this.lbl5.Location = new System.Drawing.Point(83, 380);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(338, 27);
            this.lbl5.TabIndex = 4;
            this.lbl5.Text = "and emphasize the importance and ";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.BackColor = System.Drawing.Color.Transparent;
            this.lbl4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl4.Font = new System.Drawing.Font("Corbel", 11F);
            this.lbl4.ForeColor = System.Drawing.Color.White;
            this.lbl4.Location = new System.Drawing.Point(83, 355);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(402, 27);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "Show the wisdom and security of software ";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.Transparent;
            this.lbl3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl3.Font = new System.Drawing.Font("Corbel", 8F);
            this.lbl3.ForeColor = System.Drawing.Color.White;
            this.lbl3.Location = new System.Drawing.Point(222, 283);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(89, 19);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "by ChaiYing";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl2.Font = new System.Drawing.Font("Corbel", 16F);
            this.lbl2.ForeColor = System.Drawing.Color.White;
            this.lbl2.Location = new System.Drawing.Point(81, 268);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(139, 39);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Software";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl1.Font = new System.Drawing.Font("Corbel", 32F, System.Drawing.FontStyle.Bold);
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(78, 190);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(384, 78);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "SafeWisdom";
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.top;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1281, 792);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.top.ResumeLayout(false);
            this.top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicture)).EndInit();
            this.signUp.ResumeLayout(false);
            this.signUp.PerformLayout();
            this.signIn.ResumeLayout(false);
            this.signIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.PictureBox maximize;
        private testing.DragControl dragControl1;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private GradientPanel signIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private GradientPanel signUp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label txtBtnSignUp;
        private System.Windows.Forms.Label txtBtnSignIn;
        private System.Windows.Forms.PictureBox mainPicture;
    }
}

