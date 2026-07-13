namespace Final
{
    partial class Usage
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbl1 = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.lblCPU = new MetroFramework.Controls.MetroLabel();
            this.lbl2 = new MetroFramework.Controls.MetroLabel();
            this.lbl3 = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBar2 = new MetroFramework.Controls.MetroProgressBar();
            this.metroProgressBar3 = new MetroFramework.Controls.MetroProgressBar();
            this.lblRAM = new MetroFramework.Controls.MetroLabel();
            this.lblDISK = new MetroFramework.Controls.MetroLabel();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.pDISK = new System.Diagnostics.PerformanceCounter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDISK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(42, 82);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(42, 19);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "CPU: ";
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(116, 82);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(403, 23);
            this.metroProgressBar1.TabIndex = 1;
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Location = new System.Drawing.Point(527, 82);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(27, 19);
            this.lblCPU.TabIndex = 2;
            this.lblCPU.Text = "0%";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(42, 122);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(45, 19);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "RAM: ";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(42, 163);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(42, 19);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "DISK: ";
            // 
            // metroProgressBar2
            // 
            this.metroProgressBar2.Location = new System.Drawing.Point(116, 122);
            this.metroProgressBar2.Name = "metroProgressBar2";
            this.metroProgressBar2.Size = new System.Drawing.Size(403, 23);
            this.metroProgressBar2.TabIndex = 5;
            // 
            // metroProgressBar3
            // 
            this.metroProgressBar3.Location = new System.Drawing.Point(116, 163);
            this.metroProgressBar3.Name = "metroProgressBar3";
            this.metroProgressBar3.Size = new System.Drawing.Size(403, 23);
            this.metroProgressBar3.TabIndex = 6;
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Location = new System.Drawing.Point(527, 122);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(27, 19);
            this.lblRAM.TabIndex = 7;
            this.lblRAM.Text = "0%";
            // 
            // lblDISK
            // 
            this.lblDISK.AutoSize = true;
            this.lblDISK.Location = new System.Drawing.Point(527, 163);
            this.lblDISK.Name = "lblDISK";
            this.lblDISK.Size = new System.Drawing.Size(27, 19);
            this.lblDISK.TabIndex = 8;
            this.lblDISK.Text = "0%";
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_Total";
            // 
            // pRAM
            // 
            this.pRAM.CategoryName = "Memory";
            this.pRAM.CounterName = "% Committed Bytes in Use";
            // 
            // pDISK
            // 
            this.pDISK.CategoryName = "PhysicalDisk";
            this.pDISK.CounterName = "% Disk Time";
            this.pDISK.InstanceName = "_Total";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(24, 195);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "CPU";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "RAM";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "DISK";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(558, 249);
            this.chart1.TabIndex = 9;
            // 
            // Usage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 453);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblDISK);
            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.metroProgressBar3);
            this.Controls.Add(this.metroProgressBar2);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.lbl1);
            this.Name = "Usage";
            this.Text = "Performance";
            this.Load += new System.EventHandler(this.Usage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDISK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbl1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroLabel lblCPU;
        private MetroFramework.Controls.MetroLabel lbl2;
        private MetroFramework.Controls.MetroLabel lbl3;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar2;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar3;
        private MetroFramework.Controls.MetroLabel lblRAM;
        private MetroFramework.Controls.MetroLabel lblDISK;
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Diagnostics.PerformanceCounter pRAM;
        private System.Diagnostics.PerformanceCounter pDISK;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}