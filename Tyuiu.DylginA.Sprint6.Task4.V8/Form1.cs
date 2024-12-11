using Tyuiu.DylginA.Sprint6.Task4.V8.Lib;

namespace Tyuiu.DylginA.Sprint6.Task4.V8
{
    public partial class Form1 : Form
    {
        DataService ds = new DataService();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonComplete_Click(object sender, EventArgs e)
        {
            int startValue = Convert.ToInt32(textBoxStart.Text);
            int stopValue = Convert.ToInt32(textBoxEnd.Text);
            int len = ds.GetMassFunction(startValue, stopValue).Length;
            double[] res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            this.chartResult.ChartAreas[0].AxisX.Title = "Îñü X";
            this.chartResult.ChartAreas[0].AxisY.Title = "Îñü Y";
            textBoxOut.Text = "";
            for (int i = 0; i <= len - 1; i++)
            {
                this.chartResult.Series[0].Points.AddXY(startValue, res[i]);
                textBoxOut.AppendText(res[i] + Environment.NewLine);
                startValue++;
            }
        }

        private void buttoninfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил студент группы ИБКСБ-24-1 Дылгин Антон",
              "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V10.txt";
            File.WriteAllText(path, textBoxOut.Text);

            DialogResult dialogResult = MessageBox.Show("Файл " + path + " ñîõðàíåí óñïåøíî! \nÎòêðûòü åãî â áëîêíîòå?",
                "Ñîîáùåíèå", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
        }
    }
}
