namespace Poulos_Assign6
{
    partial class Graph2
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.button1 = new System.Windows.Forms.Button();
            this.NapTime = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.NapTime)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NapTime
            // 
            chartArea1.Name = "ChartArea1";
            this.NapTime.ChartAreas.Add(chartArea1);
            legend1.Name = "Age";
            this.NapTime.Legends.Add(legend1);
            this.NapTime.Location = new System.Drawing.Point(12, 12);
            this.NapTime.Name = "NapTime";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Age";
            series1.Name = "Age";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Age";
            series2.Name = "Nap (in Minutes)";
            this.NapTime.Series.Add(series1);
            this.NapTime.Series.Add(series2);
            this.NapTime.Size = new System.Drawing.Size(857, 391);
            this.NapTime.TabIndex = 1;
            this.NapTime.Text = "NaptTime";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            title1.Name = "Nap Time";
            title1.Text = "Average Nap Times";
            this.NapTime.Titles.Add(title1);
            // 
            // Graph2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 453);
            this.Controls.Add(this.NapTime);
            this.Controls.Add(this.button1);
            this.Name = "Graph2";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Graph2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NapTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart NapTime;
    }
}