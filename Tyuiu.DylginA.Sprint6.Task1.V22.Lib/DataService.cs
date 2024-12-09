using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.DylginA.Sprint6.Task1.V22.Lib
{
    public class DataService : ISprint6Task1V22
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] MassResult = new double[11];

            int index = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double result;
                if (Math.Cos(x)+1 == 0)
                {
                    result = 0;
                }
                else
                {
                    result = 3*x+2-((2*x-x)/(Math.Cos(x)+1));
                }
                MassResult[index] = Math.Round(result,2);
                index++;
            }
            return MassResult;
        }
    }
}
