using System.Windows.Forms;
using Tyuiu.DylginA.Sprint6.Task7.V17.Lib;
namespace Tyuiu.DylginA.Sprint6.Task7.V17
{
    public partial class Form1 : Form
    {
        DataService ds = new DataService();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(openFileDialog.FileName);
                dataGridViewIn.Rows.Clear();
                dataGridViewIn.Columns.Clear();

                string[] firstLine = lines[0].Split(';');
                for (int i = 0; i < firstLine.Length; i++)
                {
                    dataGridViewIn.Columns.Add("Column" + i, "Column" + (i + 1));
                }
                foreach (var line in lines)
                {
                    string[] values = line.Split(';');
                    dataGridViewIn.Rows.Add(values);
                }
            }
        }
        private void buttonRun_Click(object sender, EventArgs e)
        {
            int rowCount = dataGridViewIn.Rows.Count;
            int colCount = dataGridViewIn.Columns.Count;
            int[,] data = new int[rowCount, colCount];
            for (int i = 0; i < rowCount - 1; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    data[i, j] = Convert.ToInt32(dataGridViewIn.Rows[i].Cells[j].Value);
                }
            }
            for (int j = 0; j < colCount; j++)
            {
                if (data[1, j] % 2 == 0)
                {
                    data[1, j] = 4;
                }
            }
            dataGridViewOut.Rows.Clear();
            dataGridViewOut.Columns.Clear();
            for (int i = 0; i < colCount; i++)
            {
                dataGridViewOut.Columns.Add("Column" + i, "Column" + (i + 1));
            }
            for (int i = 0; i < rowCount - 1; i++)
            {
                string[] row = new string[colCount];
                for (int j = 0; j < colCount; j++)
                {
                    row[j] = data[i, j].ToString();
                }
                dataGridViewOut.Rows.Add(row);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "OutPutFileTask7.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                int rowCount = dataGridViewOut.Rows.Count;
                int colCount = dataGridViewOut.Columns.Count;
                int[,] data = new int[rowCount, colCount];
                for (int i = 0; i < rowCount; i++)
                {
                    for (int j = 0; j < colCount; j++)
                    {
                        data[i, j] = Convert.ToInt32(dataGridViewOut.Rows[i].Cells[j].Value);
                    }
                }
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    for (int i = 0; i < rowCount; i++)
                    {
                        string[] row = new string[colCount];
                        for (int j = 0; j < colCount; j++)
                        {
                            row[j] = data[i, j].ToString();
                        }
                        writer.WriteLine(string.Join(";", row));
                    }
                }
            }
        }
    }
}
