namespace GeneticAlgorithmCourseWork
{
    partial class GraphicWithDataOfChromosomes
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
            this.chartForChromosomes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartForChromosomes)).BeginInit();
            this.SuspendLayout();
            // 
            // chartForChromosomes
            // 
            chartArea1.Name = "ChartArea1";
            this.chartForChromosomes.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartForChromosomes.Legends.Add(legend1);
            this.chartForChromosomes.Location = new System.Drawing.Point(12, 12);
            this.chartForChromosomes.Name = "chartForChromosomes";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartForChromosomes.Series.Add(series1);
            this.chartForChromosomes.Size = new System.Drawing.Size(1160, 570);
            this.chartForChromosomes.TabIndex = 0;
            this.chartForChromosomes.Text = "chart1";
            // 
            // GraphicWithDataOfChromosomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 575);
            this.Controls.Add(this.chartForChromosomes);
            this.Name = "GraphicWithDataOfChromosomes";
            this.Text = "GraphicWithDataOfChromosomes";
            this.Load += new System.EventHandler(this.GraphicWithDataOfChromosomes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartForChromosomes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartForChromosomes;
    }
}