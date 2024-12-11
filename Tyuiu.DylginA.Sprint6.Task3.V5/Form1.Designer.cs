namespace Tyuiu.DylginA.Sprint6.Task3.V5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dataGridResult = new DataGridView();
            buttonComplete = new Button();
            buttonInfo = new Button();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridResult).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(23, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(534, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridResult);
            groupBox2.Location = new Point(563, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(571, 352);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных";
            // 
            // dataGridResult
            // 
            dataGridResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridResult.Location = new Point(10, 24);
            dataGridResult.Name = "dataGridResult";
            dataGridResult.RowHeadersWidth = 51;
            dataGridResult.Size = new Size(300, 322);
            dataGridResult.TabIndex = 0;
            // 
            // buttonComplete
            // 
            buttonComplete.Location = new Point(1035, 409);
            buttonComplete.Name = "buttonComplete";
            buttonComplete.Size = new Size(99, 29);
            buttonComplete.TabIndex = 2;
            buttonComplete.Text = "Выполнить";
            buttonComplete.UseVisualStyleBackColor = true;
            buttonComplete.Click += buttonComplete_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(984, 409);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(29, 29);
            buttonInfo.TabIndex = 3;
            buttonInfo.Text = "?";
            buttonInfo.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 29);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(458, 317);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 450);
            Controls.Add(buttonInfo);
            Controls.Add(buttonComplete);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridResult;
        private Button buttonComplete;
        private Button buttonInfo;
        private TextBox textBox1;
    }
}
