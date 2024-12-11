namespace Tyuiu.DylginA.Sprint6.Task2.V22
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
            label2 = new Label();
            label1 = new Label();
            textBoxEnd = new TextBox();
            textBoxStart = new TextBox();
            buttonInfo = new Button();
            buttonComplete = new Button();
            groupBox3 = new GroupBox();
            chartResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridResult = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            FX = new DataGridViewTextBoxColumn();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridResult).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(8, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(521, 304);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textBoxEnd);
            groupBox2.Controls.Add(textBoxStart);
            groupBox2.Controls.Add(buttonInfo);
            groupBox2.Controls.Add(buttonComplete);
            groupBox2.Location = new Point(10, 325);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(519, 113);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 55);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 5;
            label2.Text = "Конец";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 56);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 4;
            label1.Text = "Старт";
            // 
            // textBoxEnd
            // 
            textBoxEnd.Location = new Point(162, 78);
            textBoxEnd.Name = "textBoxEnd";
            textBoxEnd.Size = new Size(125, 27);
            textBoxEnd.TabIndex = 3;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(6, 78);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(125, 27);
            textBoxStart.TabIndex = 2;
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(303, 78);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(94, 29);
            buttonInfo.TabIndex = 1;
            buttonInfo.Text = "?";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // buttonComplete
            // 
            buttonComplete.Location = new Point(416, 78);
            buttonComplete.Name = "buttonComplete";
            buttonComplete.Size = new Size(97, 29);
            buttonComplete.TabIndex = 0;
            buttonComplete.Text = "Выполнить";
            buttonComplete.UseVisualStyleBackColor = true;
            buttonComplete.Click += buttonComplete_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(chartResult);
            groupBox3.Controls.Add(dataGridResult);
            groupBox3.Location = new Point(535, 15);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(613, 423);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод данных";
            // 
            // chartResult
            // 
            chartArea1.Name = "ChartArea1";
            chartResult.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartResult.Legends.Add(legend1);
            chartResult.Location = new Point(181, 23);
            chartResult.Name = "chartResult";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartResult.Series.Add(series1);
            chartResult.Size = new Size(426, 394);
            chartResult.TabIndex = 1;
            chartResult.Text = "chart1";
            // 
            // dataGridResult
            // 
            dataGridResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridResult.Columns.AddRange(new DataGridViewColumn[] { X, FX });
            dataGridResult.Location = new Point(6, 23);
            dataGridResult.Name = "dataGridResult";
            dataGridResult.RowHeadersVisible = false;
            dataGridResult.RowHeadersWidth = 51;
            dataGridResult.Size = new Size(162, 394);
            dataGridResult.TabIndex = 0;
            dataGridResult.CellContentClick += dataGridView1_CellContentClick;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.Width = 70;
            // 
            // FX
            // 
            FX.HeaderText = "F(X)";
            FX.MinimumWidth = 6;
            FX.Name = "FX";
            FX.ReadOnly = true;
            FX.Width = 70;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 25);
            label3.Name = "label3";
            label3.Size = new Size(473, 20);
            label3.TabIndex = 0;
            label3.Text = "Написать программу, которая выводи таблицу значений фукнции";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1160, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartResult).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dataGridResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn FX;
        private Label label2;
        private Label label1;
        private TextBox textBoxEnd;
        private TextBox textBoxStart;
        private Button buttonInfo;
        private Button buttonComplete;
        private Label label3;
    }
}
