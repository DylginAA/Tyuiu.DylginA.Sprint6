using Tyuiu.DylginA.Sprint6.Task6.V10.Lib;
namespace Tyuiu.DylginA.Sprint6.Task6.V10
{
    public partial class Form1 : Form
    {
        DataService ds = new DataService();
        private string path = "";
        public Form1()
        {
            InitializeComponent();
            buttonComplete.Enabled = false;
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;
                textBoxIn.Text = File.ReadAllText(path);
                buttonComplete.Enabled = true;
            }
        }

        private void buttonComplete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("Ñםאקאכא גûבונטעו פאיכ!");
                return;
            }
            string result = ds.CollectTextFromFile(path);
            textBoxOut.Text = result;

        }
    }
}
