using System.Drawing;
using Tyuiu.DylginA.Sprint6.Task1.V22.Lib;
namespace Tyuiu.DylginA.Sprint6.Task1.V22
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
            int startValue = Convert.ToInt32(textBoxStart.Text);
            int stopValue = Convert.ToInt32(textBoxEnd.Text);

            string strLine;
            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];
            valueArray = ds.GetMassFunction(startValue, stopValue);

            textBoxResult.Text = "";
            textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);
            textBoxResult.AppendText("|    X     |    F     |" + Environment.NewLine);
            textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);
            for (int i = 0; i <= len - 1; i++)
            {
                strLine = String.Format("|{0,5}    |  {1, 6:f2}   |", startValue, valueArray[i]);
                textBoxResult.AppendText(strLine + Environment.NewLine);
                startValue++;
            }
        }
    }
}
