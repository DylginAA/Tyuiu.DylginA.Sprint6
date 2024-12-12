using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.DylginA.Sprint6.Task5.V1.Lib
{
    public class DataService : ISprint6Task5V1
    {
        public double[] LoadFromDataFile(string path)
        {
            List<double> numbers = new List<double>();
            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                double number;
                bool isNumber = double.TryParse(line, out number);
                if (isNumber)
                {
                    numbers.Add(number);
                }
            }

            return numbers.ToArray();
        }
    }
}
