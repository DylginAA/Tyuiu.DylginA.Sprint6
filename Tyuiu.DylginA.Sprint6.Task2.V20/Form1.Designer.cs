namespace Tyuiu.DylginA.Sprint6.Task2.V20
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            chartResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewResult = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            FX = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            button2 = new Button();
            buttonComplete = new Button();
            textBoxEndVal = new TextBox();
            textBoxStartVal = new TextBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(10, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(495, 334);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chartResult);
            groupBox2.Controls.Add(dataGridViewResult);
            groupBox2.Location = new Point(543, 7);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(550, 431);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных";
            // 
            // chartResult
            // 
            chartArea1.Name = "ChartArea1";
            chartResult.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartResult.Legends.Add(legend1);
            chartResult.Location = new Point(179, 23);
            chartResult.Name = "chartResult";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartResult.Series.Add(series1);
            chartResult.Size = new Size(365, 375);
            chartResult.TabIndex = 1;
            chartResult.Text = "chart1";
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.Columns.AddRange(new DataGridViewColumn[] { X, FX });
            dataGridViewResult.Location = new Point(10, 24);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.RowHeadersVisible = false;
            dataGridViewResult.RowHeadersWidth = 51;
            dataGridViewResult.Size = new Size(165, 188);
            dataGridViewResult.TabIndex = 0;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.ReadOnly = true;
            X.Width = 80;
            // 
            // FX
            // 
            FX.HeaderText = "F(X)";
            FX.MinimumWidth = 6;
            FX.Name = "FX";
            FX.ReadOnly = true;
            FX.Width = 80;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(buttonComplete);
            groupBox3.Controls.Add(textBoxEndVal);
            groupBox3.Controls.Add(textBoxStartVal);
            groupBox3.Location = new Point(10, 347);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(495, 91);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ввод данных";
            // 
            // button2
            // 
            button2.Location = new Point(324, 56);
            button2.Name = "button2";
            button2.Size = new Size(34, 29);
            button2.TabIndex = 3;
            button2.Text = "?";
            button2.UseVisualStyleBackColor = true;
            // 
            // buttonComplete
            // 
            buttonComplete.Location = new Point(384, 56);
            buttonComplete.Name = "buttonComplete";
            buttonComplete.Size = new Size(105, 29);
            buttonComplete.TabIndex = 2;
            buttonComplete.Text = "Выполнить";
            buttonComplete.UseVisualStyleBackColor = true;
            buttonComplete.Click += buttonComplete_Click;
            // 
            // textBoxEndVal
            // 
            textBoxEndVal.Location = new Point(148, 58);
            textBoxEndVal.Name = "textBoxEndVal";
            textBoxEndVal.Size = new Size(125, 27);
            textBoxEndVal.TabIndex = 1;
            // 
            // textBoxStartVal
            // 
            textBoxStartVal.Location = new Point(6, 58);
            textBoxStartVal.Name = "textBoxStartVal";
            textBoxStartVal.Size = new Size(125, 27);
            textBoxStartVal.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartResult).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button button2;
        private Button buttonComplete;
        private TextBox textBoxEndVal;
        private TextBox textBoxStartVal;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult;
        private DataGridView dataGridViewResult;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn FX;
    }
}
