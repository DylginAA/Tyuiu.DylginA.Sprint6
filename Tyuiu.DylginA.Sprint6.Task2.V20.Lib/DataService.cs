using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.DylginA.Sprint6.Task2.V20.Lib
{
    public class DataService : ISprint6Task2V22
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] MassResult = new double[11];

            int index = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double result;
                if (x + 1.2 == 0)
                {
                    result = 0;
                }
                else
                {
                    result = ((Math.Sin(x) / (x + 1.2)) + Math.Cos(x) * 7 * x - 2);
                }
                MassResult[index] = Math.Round(result, 2);
                index++;
            }
            return MassResult;
        }
    }
}
