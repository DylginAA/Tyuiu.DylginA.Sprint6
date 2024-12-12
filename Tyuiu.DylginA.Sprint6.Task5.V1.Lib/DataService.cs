using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.DylginA.Sprint6.Task5.V1.Lib
{
    public class DataService : ISprint6Task5V1
    {
        public double[] LoadFromDataFile(string path)
        {
            string[] lines = File.ReadAllLines(path);

            double[] positiveNumbers = new double[lines.Length];
            int index = 0;
            foreach (string line in lines)
            {
                double number = Convert.ToDouble(line); 

                if (number > 0)
                {
                    positiveNumbers[index] = Math.Round(number, 3);
                    index++;
                }
            }
            double[] result = new double[index];
            Array.Copy(positiveNumbers, result, index);

            return result;
        }
    }
}
