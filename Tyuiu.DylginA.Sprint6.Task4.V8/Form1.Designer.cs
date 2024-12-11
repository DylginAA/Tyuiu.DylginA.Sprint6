namespace Tyuiu.DylginA.Sprint6.Task4.V8
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
            groupBox3 = new GroupBox();
            chartResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridView1 = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            FX = new DataGridViewTextBoxColumn();
            buttonComplete = new Button();
            buttonInfo = new Button();
            textBoxOut = new TextBox();
            buttonSave = new Button();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(11, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(462, 343);
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
            groupBox2.Location = new Point(11, 355);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(462, 91);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 33);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 3;
            label2.Text = "Конец шага";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 34);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 2;
            label1.Text = "Страт шага";
            // 
            // textBoxEnd
            // 
            textBoxEnd.Location = new Point(160, 56);
            textBoxEnd.Name = "textBoxEnd";
            textBoxEnd.Size = new Size(125, 27);
            textBoxEnd.TabIndex = 1;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(6, 56);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(125, 27);
            textBoxStart.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(chartResult);
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(479, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(687, 363);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод данных";
            // 
            // chartResult
            // 
            chartArea1.Name = "ChartArea1";
            chartResult.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartResult.Legends.Add(legend1);
            chartResult.Location = new Point(172, 30);
            chartResult.Name = "chartResult";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartResult.Series.Add(series1);
            chartResult.Size = new Size(509, 327);
            chartResult.TabIndex = 1;
            chartResult.Text = "chart1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { X, FX });
            dataGridView1.Location = new Point(14, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(143, 328);
            dataGridView1.TabIndex = 0;
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
            // buttonComplete
            // 
            buttonComplete.Location = new Point(1050, 409);
            buttonComplete.Name = "buttonComplete";
            buttonComplete.Size = new Size(116, 29);
            buttonComplete.TabIndex = 3;
            buttonComplete.Text = "Выполнить";
            buttonComplete.UseVisualStyleBackColor = true;
            buttonComplete.Click += buttonComplete_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(972, 409);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(54, 29);
            buttonInfo.TabIndex = 4;
            buttonInfo.Text = "?";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttoninfo_Click;
            // 
            // textBoxOut
            // 
            textBoxOut.Location = new Point(659, 387);
            textBoxOut.Name = "textBoxOut";
            textBoxOut.Size = new Size(271, 27);
            textBoxOut.TabIndex = 5;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(500, 383);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(136, 29);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 450);
            Controls.Add(buttonSave);
            Controls.Add(textBoxOut);
            Controls.Add(buttonInfo);
            Controls.Add(buttonComplete);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartResult).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBoxEnd;
        private TextBox textBoxStart;
        private GroupBox groupBox3;
        private Button buttonComplete;
        private Button buttonInfo;
        private Label label2;
        private Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn FX;
        private TextBox textBoxOut;
        private Button buttonSave;
    }
}
