using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.DylginA.Sprint6.Task4.V8.Lib
{
    public class DataService : ISprint6Task4V8
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] MassResult = new double[11];
            string newpath = Path.Combine(Path.GetTempPath(), "DataSprint6", "OutPutDataFileTask1.txt");
            int index = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double y;
                if (x + 1.2 == 0)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Round(Math.Sin(x) + ((Math.Cos(x)+1)/(2-x)) + 2*x,2);
                    string strY = Convert.ToString(y);
                    File.AppendAllText(newpath, strY + Environment.NewLine);
                }
                MassResult[index] = Math.Round(y, 2);
                index++;
            }

            return MassResult;
        }
    }
}
