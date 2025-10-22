using System;
using Tyuiu.KhanikyanDK.Sprint4.Task5.V19.Lib;

namespace Tyuiu.KhanikyanDK.Sprint4.Task5.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт 4 | Выполнил: Ханикян Д. К. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт 4                                                                *");
            Console.WriteLine("* Тема: Работа с двумерными массивами в C#                                *");
            Console.WriteLine("* Задание 5                                                               *");
            Console.WriteLine("* Вариант 19                                                              *");
            Console.WriteLine("* Выполнил: Ханикян Давит Каренович | ИСТНб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5×5,                                 *");
            Console.WriteLine("* заполненный случайными значениями в диапазоне от -2 до 3.               *");
            Console.WriteLine("* Найти количество положительных элементов массива.                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = new int[5, 5];
            Random rnd = new Random();

            for (int i = 0; i < 5; i++) ;
            for (int i = 0; i < 5; i++) 
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = rnd.Next(-2, 4);
                    Console.Write($"{matrix[i, j], 5}"); // (ширина) выравнивает по кравому краю для красоты
                }
                Console.WriteLine();
            }

            DataService ds = new DataService(); 
            int result = ds.Calculate(matrix);
             
            Console.WriteLine("***************************************************************************"); 
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество положительных элементов массива = " + result);
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}