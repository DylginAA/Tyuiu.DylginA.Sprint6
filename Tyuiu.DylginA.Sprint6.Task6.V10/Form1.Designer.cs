namespace Tyuiu.DylginA.Sprint6.Task6.V10
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
            components = new System.ComponentModel.Container();
            buttonOpenFile = new Button();
            buttonComplete = new Button();
            openFileDialog1 = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            textBoxIn = new TextBox();
            textBoxOut = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Location = new Point(24, 12);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(106, 35);
            buttonOpenFile.TabIndex = 0;
            buttonOpenFile.Text = "Открыть";
            toolTip1.SetToolTip(buttonOpenFile, "Открыть файл");
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // buttonComplete
            // 
            buttonComplete.Location = new Point(175, 12);
            buttonComplete.Name = "buttonComplete";
            buttonComplete.Size = new Size(103, 35);
            buttonComplete.TabIndex = 1;
            buttonComplete.Text = "Выполнить";
            toolTip1.SetToolTip(buttonComplete, "Вывести слова в которых встречается w в результирующею строку и вывести ее в textBoxOut.");
            buttonComplete.UseVisualStyleBackColor = true;
            buttonComplete.Click += buttonComplete_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxIn
            // 
            textBoxIn.Location = new Point(14, 26);
            textBoxIn.Multiline = true;
            textBoxIn.Name = "textBoxIn";
            textBoxIn.Size = new Size(497, 364);
            textBoxIn.TabIndex = 2;
            // 
            // textBoxOut
            // 
            textBoxOut.Location = new Point(16, 26);
            textBoxOut.Multiline = true;
            textBoxOut.Name = "textBoxOut";
            textBoxOut.Size = new Size(495, 364);
            textBoxOut.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxIn);
            groupBox1.Location = new Point(12, 144);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(528, 396);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxOut);
            groupBox2.Location = new Point(594, 144);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(517, 396);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод";
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(26, 59);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1079, 88);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Условие";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 543);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(buttonComplete);
            Controls.Add(buttonOpenFile);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOpenFile;
        private Button buttonComplete;
        private OpenFileDialog openFileDialog1;
        private ToolTip toolTip1;
        private TextBox textBoxIn;
        private TextBox textBoxOut;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}
