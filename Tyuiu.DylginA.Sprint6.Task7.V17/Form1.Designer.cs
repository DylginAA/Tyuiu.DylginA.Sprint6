namespace Tyuiu.DylginA.Sprint6.Task7.V17
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
            groupBox1 = new GroupBox();
            buttonSave = new Button();
            buttonRun = new Button();
            buttonLoad = new Button();
            groupBox2 = new GroupBox();
            dataGridViewIn = new DataGridView();
            n = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            dataGridViewOut = new DataGridView();
            nn = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonSave);
            groupBox1.Controls.Add(buttonRun);
            groupBox1.Controls.Add(buttonLoad);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1103, 75);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(270, 27);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(106, 43);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonRun
            // 
            buttonRun.Location = new Point(145, 27);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new Size(106, 42);
            buttonRun.TabIndex = 1;
            buttonRun.Text = "Выполнить";
            buttonRun.UseVisualStyleBackColor = true;
            buttonRun.Click += buttonRun_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(18, 27);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(111, 42);
            buttonLoad.TabIndex = 0;
            buttonLoad.Text = "Открыть";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewIn);
            groupBox2.Location = new Point(14, 95);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(491, 355);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод";
            // 
            // dataGridViewIn
            // 
            dataGridViewIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn.Columns.AddRange(new DataGridViewColumn[] { n });
            dataGridViewIn.Location = new Point(3, 19);
            dataGridViewIn.Name = "dataGridViewIn";
            dataGridViewIn.RowHeadersWidth = 51;
            dataGridViewIn.Size = new Size(482, 330);
            dataGridViewIn.TabIndex = 0;
            // 
            // n
            // 
            n.HeaderText = "Column1";
            n.MinimumWidth = 6;
            n.Name = "n";
            n.ReadOnly = true;
            n.Width = 125;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridViewOut);
            groupBox3.Location = new Point(554, 95);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(561, 355);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод";
            // 
            // dataGridViewOut
            // 
            dataGridViewOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut.Columns.AddRange(new DataGridViewColumn[] { nn });
            dataGridViewOut.Location = new Point(4, 17);
            dataGridViewOut.Name = "dataGridViewOut";
            dataGridViewOut.RowHeadersWidth = 51;
            dataGridViewOut.Size = new Size(551, 332);
            dataGridViewOut.TabIndex = 0;
            // 
            // nn
            // 
            nn.HeaderText = "Column1";
            nn.MinimumWidth = 6;
            nn.Name = "nn";
            nn.ReadOnly = true;
            nn.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 462);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridViewIn;
        private DataGridViewTextBoxColumn n;
        private GroupBox groupBox3;
        private DataGridView dataGridViewOut;
        private DataGridViewTextBoxColumn nn;
        private Button buttonSave;
        private Button buttonRun;
        private Button buttonLoad;
    }
}
