namespace School_Management_System
{
    partial class Dashboardfrm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStudentNum = new System.Windows.Forms.Label();
            this.chartsplineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartFemaleStudent = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pieChartAttendance = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartsplineChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFemaleStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChartAttendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblStudentNum);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(30, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 208);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(122, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student";
            // 
            // lblStudentNum
            // 
            this.lblStudentNum.AutoSize = true;
            this.lblStudentNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentNum.ForeColor = System.Drawing.Color.White;
            this.lblStudentNum.Location = new System.Drawing.Point(161, 100);
            this.lblStudentNum.Name = "lblStudentNum";
            this.lblStudentNum.Size = new System.Drawing.Size(95, 36);
            this.lblStudentNum.TabIndex = 1;
            this.lblStudentNum.Text = "label1";
            // 
            // chartsplineChart
            // 
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(181)))));
            chartArea1.Name = "ChartArea1";
            this.chartsplineChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartsplineChart.Legends.Add(legend1);
            this.chartsplineChart.Location = new System.Drawing.Point(30, 317);
            this.chartsplineChart.Name = "chartsplineChart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.White;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Cash";
            this.chartsplineChart.Series.Add(series1);
            this.chartsplineChart.Size = new System.Drawing.Size(1617, 469);
            this.chartsplineChart.TabIndex = 2;
            this.chartsplineChart.Text = "chart1";
            // 
            // chartFemaleStudent
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFemaleStudent.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFemaleStudent.Legends.Add(legend2);
            this.chartFemaleStudent.Location = new System.Drawing.Point(1198, 33);
            this.chartFemaleStudent.Name = "chartFemaleStudent";
            this.chartFemaleStudent.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.IsValueShownAsLabel = true;
            series2.IsXValueIndexed = true;
            series2.LabelFormat = "##.##%";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFemaleStudent.Series.Add(series2);
            this.chartFemaleStudent.Size = new System.Drawing.Size(431, 208);
            this.chartFemaleStudent.TabIndex = 3;
            this.chartFemaleStudent.Text = "chart2";
            // 
            // pieChartAttendance
            // 
            chartArea3.Name = "ChartArea1";
            this.pieChartAttendance.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.pieChartAttendance.Legends.Add(legend3);
            this.pieChartAttendance.Location = new System.Drawing.Point(634, 33);
            this.pieChartAttendance.Name = "pieChartAttendance";
            this.pieChartAttendance.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.IsValueShownAsLabel = true;
            series3.IsXValueIndexed = true;
            series3.LabelFormat = "##.##%";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.pieChartAttendance.Series.Add(series3);
            this.pieChartAttendance.Size = new System.Drawing.Size(431, 208);
            this.pieChartAttendance.TabIndex = 4;
            this.pieChartAttendance.Text = "chart2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::School_Management_System.Properties.Resources.graduate_64px;
            this.pictureBox1.Location = new System.Drawing.Point(21, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Dashboardfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1659, 831);
            this.Controls.Add(this.pieChartAttendance);
            this.Controls.Add(this.chartFemaleStudent);
            this.Controls.Add(this.chartsplineChart);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboardfrm";
            this.Text = "Dashboardfrm";
            this.Load += new System.EventHandler(this.Dashboardfrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartsplineChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFemaleStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChartAttendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStudentNum;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartsplineChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFemaleStudent;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChartAttendance;
    }
}