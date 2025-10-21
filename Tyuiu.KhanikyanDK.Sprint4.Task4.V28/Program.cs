using System;
using Tyuiu.KhanikyanDK.Sprint4.Task4.V28.Lib;

namespace Tyuiu.KhanikyanDK.Sprint4.Task4.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт 4 | Выполнил: Ханикян Д. К. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт 4                                                                *");
            Console.WriteLine("* Тема: Работа с двумерными массивами в C#                                *");
            Console.WriteLine("* Задание 4                                                               *");
            Console.WriteLine("* Вариант 28                                                              *");
            Console.WriteLine("* Выполнил: Ханикян Давит Каренович | ИСТНб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5×5, заполненный значениями          *");
            Console.WriteLine("* с клавиатуры в диапазоне от 1 до 5. Заменыть четные элементы массива на 1.*");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write($"Введите количество строк матрицы: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Введите количество столбцов матрицы: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Введите элемент [{i},{j}]: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    Console.Write(matrix[i, j] + "\t");
                Console.WriteLine();
            }

            DataService ds = new DataService();
            int[,] result = ds.Calculate(matrix);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    Console.Write(result[i, j] + "\t");
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}