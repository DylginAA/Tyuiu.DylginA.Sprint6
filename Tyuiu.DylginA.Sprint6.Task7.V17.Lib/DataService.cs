using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.DylginA.Sprint6.Task7.V17.Lib
{
    public class DataService : ISprint6Task7V17
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);
            int rowCount = lines.Length;
            int colCount = lines[0].Split(';').Length;

            int[,] data = new int[rowCount, colCount];
            for (int i = 0; i < rowCount; i++)
            {
                string[] values = lines[i].Split(';');
                for (int j = 0; j < colCount; j++)
                {
                    data[i, j] = int.Parse(values[j]);
                }
            }
            for (int j = 0; j < colCount; j++)
            {
                if (data[1, j] % 2 == 0)
                {
                    data[1, j] = 4;
                }
            }
            return data;
        }
    }
}
