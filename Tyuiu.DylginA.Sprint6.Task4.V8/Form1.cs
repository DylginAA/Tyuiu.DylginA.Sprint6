using System.Windows.Forms.DataVisualization.Charting;
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
            dataGridResult.Rows.Clear();
            chartResult.Series["F(x)"].Points.Clear();
            int startValue = Convert.ToInt32(textBoxStart.Text);
            int stopValue = Convert.ToInt32(textBoxEnd.Text);
            double[] results = ds.GetMassFunction(startValue, stopValue);

            for (int i = 0; i < results.Length; i++)
            {
                int x = startValue + i;
                double y = results[i];

                dataGridResult.Rows.Add(x, y);
                chartResult.Series["F(x)"].Points.AddXY(x, y);
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
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (DataGridViewRow row in dataGridResult.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                    {
                        writer.WriteLine($"x = {row.Cells[0].Value}, F(x) = {row.Cells[1].Value}");
                    }
                }
            }

            MessageBox.Show("Результаты сохранены в файл!", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chartResult.Series.Clear();
            chartResult.Series.Add("F(x)");
            chartResult.Series["F(x)"].ChartType = SeriesChartType.Line;
        }
    }
}
