using System.Windows.Forms;
using Tyuiu.DylginA.Sprint6.Task3.V5.Lib;
namespace Tyuiu.DylginA.Sprint6.Task3.V5
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
            int[,] matrix = new int[5, 5]
        {
                { 30, -20,   7,  -8 ,  9 },

                { 32,  17, -14 , -7,  33 },

               { 19, -19, -13,  14, -20 },

                { 11,  30,  -1 , 26,   6 },

                { 30, -15, -20,  -5,  15}
        };
            int[,] res = ds.Calculate(matrix);
            int rows = res.GetUpperBound(0) + 1;
            int coll = res.Length / rows;
            dataGridResult.ColumnCount = coll;
            dataGridResult.RowCount = rows;
            for (int i = 0; i < coll; i++)
            {
                dataGridResult.Columns[i].Width = 30;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < coll; j++)
                {
                    dataGridResult.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }
    }
}
