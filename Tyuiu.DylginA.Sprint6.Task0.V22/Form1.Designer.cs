namespace Tyuiu.DylginA.Sprint6.Task0.V22
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
            buttonComplete = new Button();
            textBoxResult = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            chart1 = new FastReport.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // buttonComplete
            // 
            buttonComplete.Location = new Point(330, 277);
            buttonComplete.Name = "buttonComplete";
            buttonComplete.Size = new Size(125, 29);
            buttonComplete.TabIndex = 0;
            buttonComplete.Text = "Выполнить";
            buttonComplete.UseVisualStyleBackColor = true;
            buttonComplete.Click += buttonComplete_click;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(236, 191);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(301, 27);
            textBoxResult.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 22);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 5;
            label1.Text = "Условие:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 67);
            label2.Name = "label2";
            label2.Size = new Size(305, 20);
            label2.TabIndex = 6;
            label2.Text = "Вычислить результат выражение при Х=2.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(347, 146);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 10;
            label6.Text = "Результат";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(439, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 62);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // chart1
            // 
            chart1.Location = new Point(461, 132);
            chart1.Name = "chart1";
            chart1.Size = new Size(289, 229);
            chart1.TabIndex = 12;
            chart1.Text = "chart1";
            chart1.Click += chart1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chart1);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxResult);
            Controls.Add(buttonComplete);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonComplete;
        private TextBox textBoxResult;
        private Label label1;
        private Label label2;
        private Label label6;
        private PictureBox pictureBox1;
        private FastReport.DataVisualization.Charting.Chart chart1;
    }
}
