namespace Lab2
{
    partial class Graphs
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.asdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.textChart)).BeginInit();
            this.SuspendLayout();
            // 
            // textChart
            // 
            chartArea2.CursorX.AutoScroll = false;
            chartArea2.CursorX.LineColor = System.Drawing.Color.DarkRed;
            chartArea2.Name = "ChartArea1";
            this.textChart.ChartAreas.Add(chartArea2);
            this.textChart.Location = new System.Drawing.Point(12, 36);
            this.textChart.Name = "textChart";
            this.textChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.LabelForeColor = System.Drawing.Color.Maroon;
            series2.Name = "Series1";
            this.textChart.Series.Add(series2);
            this.textChart.Size = new System.Drawing.Size(776, 175);
            this.textChart.TabIndex = 1;
            this.textChart.Text = "chart1";
            this.textChart.Click += new System.EventHandler(this.textChart_Click);
            // 
            // asdTextBox
            // 
            this.asdTextBox.Location = new System.Drawing.Point(12, 245);
            this.asdTextBox.Multiline = true;
            this.asdTextBox.Name = "asdTextBox";
            this.asdTextBox.Size = new System.Drawing.Size(776, 193);
            this.asdTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(268, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Частоты появления символов";
            // 
            // Graphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.asdTextBox);
            this.Controls.Add(this.textChart);
            this.Name = "Graphs";
            this.Text = "HistoGramma";
            ((System.ComponentModel.ISupportInitialize)(this.textChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart textChart;
        private System.Windows.Forms.TextBox asdTextBox;
        private System.Windows.Forms.Label label1;
    }
}