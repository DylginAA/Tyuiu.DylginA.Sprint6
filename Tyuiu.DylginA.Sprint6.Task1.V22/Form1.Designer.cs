namespace Tyuiu.DylginA.Sprint6.Task1.V22
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
            groupBox2 = new GroupBox();
            textBoxResult = new TextBox();
            groupBox3 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            buttonComplete = new Button();
            button1 = new Button();
            textBoxEnd = new TextBox();
            textBoxStart = new TextBox();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(23, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(687, 290);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxResult);
            groupBox2.Location = new Point(824, 17);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(297, 428);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(16, 26);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(267, 385);
            textBoxResult.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(buttonComplete);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(textBoxEnd);
            groupBox3.Controls.Add(textBoxStart);
            groupBox3.Location = new Point(26, 329);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(684, 116);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ввод данных";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(173, 57);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 5;
            label2.Text = "Конец";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 55);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 4;
            label1.Text = "Старт шага";
            // 
            // buttonComplete
            // 
            buttonComplete.Location = new Point(538, 64);
            buttonComplete.Name = "buttonComplete";
            buttonComplete.Size = new Size(116, 45);
            buttonComplete.TabIndex = 3;
            buttonComplete.Text = "Выполнить";
            buttonComplete.UseVisualStyleBackColor = true;
            buttonComplete.Click += buttonComplete_Click;
            // 
            // button1
            // 
            button1.Location = new Point(377, 62);
            button1.Name = "button1";
            button1.Size = new Size(112, 47);
            button1.TabIndex = 2;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBoxEnd
            // 
            textBoxEnd.Location = new Point(171, 82);
            textBoxEnd.Name = "textBoxEnd";
            textBoxEnd.Size = new Size(125, 27);
            textBoxEnd.TabIndex = 1;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(6, 82);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(125, 27);
            textBoxStart.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label2;
        private Label label1;
        private Button buttonComplete;
        private Button button1;
        private TextBox textBoxEnd;
        private TextBox textBoxStart;
        private TextBox textBoxResult;
    }
}
