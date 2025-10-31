using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KhanikyanDK.Sprint4.Task5.V19.Lib
{
    public class DataService : ISprint4Task5V19
    {
        public int Calculate(int[,] array)
        {
            int count = 0;
            int rows = array.GetUpperBound(0) + 1;  
            int cols = array.GetUpperBound(1) + 1; 

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (array[i, j] > 0)
                        count++;
                }
            }

            return count;
        }
    }
}