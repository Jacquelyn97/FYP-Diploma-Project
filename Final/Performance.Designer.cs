namespace Final
{
    partial class Performance
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold);
            this.lbl1.Location = new System.Drawing.Point(258, 179);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(219, 44);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Performance";
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Bold);
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(934, 179);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(108, 44);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl2.Font = new System.Drawing.Font("Corbel", 11.5F);
            this.lbl2.Location = new System.Drawing.Point(261, 326);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(765, 28);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Computer performance refers to the speed and efficiency with which computers ";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl3.Font = new System.Drawing.Font("Corbel", 11.5F);
            this.lbl3.Location = new System.Drawing.Point(261, 390);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(785, 28);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "process and perform tasks. It is estimated from the accuracy, efficiency, and spe" +
    "ed ";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl4.Font = new System.Drawing.Font("Corbel", 11.5F);
            this.lbl4.Location = new System.Drawing.Point(261, 454);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(790, 28);
            this.lbl4.TabIndex = 5;
            this.lbl4.Text = "with which the instructions of a computer program are executed. You can press the" +
    " ";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl5.Font = new System.Drawing.Font("Corbel", 11.5F);
            this.lbl5.Location = new System.Drawing.Point(261, 518);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(554, 28);
            this.lbl5.TabIndex = 6;
            this.lbl5.Text = "“View” button to view the performance of your computer.";
            // 
            // Performance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lbl1);
            this.Name = "Performance";
            this.Size = new System.Drawing.Size(1276, 742);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
    }
}
