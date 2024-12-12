using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.DylginA.Sprint6.Task4.V8.Lib
{
    public class DataService : ISprint6Task4V8
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {

            int len = (stopValue - startValue) + 1;
            double[] result = new double[len];
            double y;
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (2 - x == 0)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Sin(x) + ((Math.Cos(x) + 1) / (2 - x)) + 2 * x;
                    y = Math.Round(y, 2);
                }

                result[count] = y;
                count++;
            }

            return result;
        }
    }
}
