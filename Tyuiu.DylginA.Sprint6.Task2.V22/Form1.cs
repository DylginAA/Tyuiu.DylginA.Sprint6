using Tyuiu.DylginA.Sprint6.Task2.V22.Lib;
namespace Tyuiu.DylginA.Sprint6.Task2.V22
{
    public partial class Form1 : Form
    {
        DataService ds = new DataService();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonComplete_Click(object sender, EventArgs e)
        {
            int startValue = Convert.ToInt32(textBoxStart.Text);
            int stopValue = Convert.ToInt32(textBoxEnd.Text);

            string strLine;
            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];
            valueArray = ds.GetMassFunction(startValue, stopValue);

            this.chartResult.Titles.Add("Уравнение F(X)= sin(x) / x + 1,2 + cos(x) * 7x - 2");
            this.chartResult.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartResult.ChartAreas[0].AxisY.Title = "Ось Y";
            for (int i = 0; i <= len - 1; i++)
            {
                this.dataGridResult.Rows.Add(Convert.ToString(startValue), Convert.ToString(valueArray[i]));
                this.chartResult.Series[0].Points.AddXY(startValue, valueArray[i]);
                startValue++;
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
