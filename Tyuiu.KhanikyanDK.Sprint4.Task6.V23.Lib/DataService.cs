using tyuiu.cources.programming.interfaces.Sprint4;
using System;

namespace Tyuiu.KhanikyanDK.Sprint4.Task6.V23.Lib
{
    public class DataService : ISprint4Task6V23
    {
        public int Calculate(string[] array)
        {
            int count = 0;

            Array.ForEach(array, s =>
            {
                if (s.Length == 6)
                    count++;
            });

            return count;
        }
    }
}
