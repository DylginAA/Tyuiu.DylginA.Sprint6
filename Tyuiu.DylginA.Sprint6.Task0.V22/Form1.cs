using System.Windows.Forms;
using Tyuiu.DylginA.Sprint6.Task0.V22.Lib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Tyuiu.DylginA.Sprint6.Task0.V22
{
    public partial class Form1 : Form
    {
        DataService ds = new DataService();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonComplete_click(object sender, EventArgs e)
        {
            int x = 2;
            double result = ds.Calculate(x);
            textBoxResult.Text = result.ToString();
        }
    }
}
