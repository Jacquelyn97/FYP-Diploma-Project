namespace Final
{
    partial class VirusTotal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VirusTotal));
            this.top = new System.Windows.Forms.Panel();
            this.txtTitle = new System.Windows.Forms.Label();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.maximize = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.dragControl1 = new testing.DragControl();
            this.top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.White;
            this.top.Controls.Add(this.txtTitle);
            this.top.Controls.Add(this.minimize);
            this.top.Controls.Add(this.maximize);
            this.top.Controls.Add(this.close);
            this.top.Dock = System.Windows.Forms.DockStyle.Top;
            this.top.Location = new System.Drawing.Point(0, 0);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(926, 49);
            this.top.TabIndex = 0;
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtTitle.Font = new System.Drawing.Font("Corbel", 9F);
            this.txtTitle.Location = new System.Drawing.Point(14, 13);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(85, 22);
            this.txtTitle.TabIndex = 9;
            this.txtTitle.Text = "VirusTotal";
            // 
            // minimize
            // 
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.Location = new System.Drawing.Point(816, 12);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(26, 26);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize.TabIndex = 7;
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // maximize
            // 
            this.maximize.Cursor = System.Windows.Forms.Cursors.No;
            this.maximize.Image = ((System.Drawing.Image)(resources.GetObject("maximize.Image")));
            this.maximize.Location = new System.Drawing.Point(850, 12);
            this.maximize.Name = "maximize";
            this.maximize.Size = new System.Drawing.Size(26, 26);
            this.maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximize.TabIndex = 6;
            this.maximize.TabStop = false;
            // 
            // close
            // 
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(883, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(26, 26);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 5;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.webView21);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(926, 547);
            this.panel2.TabIndex = 1;
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(0, 0);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(926, 547);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.top;
            // 
            // VirusTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 596);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VirusTotal";
            this.Text = "VirusTotal";
            this.Load += new System.EventHandler(this.VirusTotal_Load);
            this.top.ResumeLayout(false);
            this.top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.PictureBox maximize;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private testing.DragControl dragControl1;
    }
}