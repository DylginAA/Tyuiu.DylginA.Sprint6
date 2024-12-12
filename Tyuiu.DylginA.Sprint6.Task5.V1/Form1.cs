using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using Tyuiu.DylginA.Sprint6.Task5.V1.Lib;

namespace Tyuiu.DylginA.Sprint6.Task5.V1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonComplete_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Path.GetTempPath(), "DataSprint6", "InPutDataFileTask5V1.txt");
            double[] numbers = ds.LoadFromDataFile(path);

            var positiveNumbers = new System.Collections.Generic.List<double>();
            foreach (double number in numbers)
            {
                if (number > 0)
                {
                    positiveNumbers.Add(number);
                }
            }

            dataGridResult.Rows.Clear();
            foreach (double number in positiveNumbers)
            {
                dataGridResult.Rows.Add(Math.Round(number, 3));
            }

            chartResult.Series.Clear();
            Series series = new Series
            {
                Name = "Positive Numbers",
                IsVisibleInLegend = false,
                ChartType = SeriesChartType.Column
            };

            foreach (double number in positiveNumbers)
            {
                series.Points.Add(number);
            }

            chartResult.Series.Add(series);
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�������� ������ �����. ������ �����-24-1");
        }
    }
}
