using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.DylginA.Sprint6.Task0.V22.Lib
{
    public class DataService : ISprint6Task0V22
    {
        public double Calculate(int x)
        {
            double result = 0.7 * Math.Pow(x,3) + 1.52 * Math.Pow(x, 2);
            result = Math.Round(result, 3);
            return result;
        }
    }
}
