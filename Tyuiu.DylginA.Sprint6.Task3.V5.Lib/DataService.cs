using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.DylginA.Sprint6.Task3.V5.Lib
{
    public class DataService : ISprint6Task3V5
    {
        public int[,] Calculate(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = i + 1; j < matrix.GetLength(0); j++)
                {
                    if (matrix[j, 2] < matrix[i, 2])
                    {
                        int temp = matrix[i, 2];
                        matrix[i, 2] = matrix[j, 2];
                        matrix[j, 2] = temp;
                    }
                }
            }
            return matrix;
            /*
              30 -20   7  -8   9

              32  17 -14  -7  33

              19 -19 -13  14 -20

              11  30  -1  26   6

              30 -15 -20  -5  15
            */
        }
    }
}
