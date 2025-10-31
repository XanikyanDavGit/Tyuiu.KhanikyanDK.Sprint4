using System;
using Tyuiu.KhanikyanDK.Sprint4.Task7.V4.Lib;

namespace Tyuiu.KhanikyanDK.Sprint4.Task7.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт 4 | Выполнил: Ханикян Д. К. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт 4                                                                *");
            Console.WriteLine("* Тема: Работа с двумерными массивами и строками в C#                     *");
            Console.WriteLine("* Задание 7                                                               *");
            Console.WriteLine("* Вариант 4                                                               *");
            Console.WriteLine("* Выполнил: Ханикян Давит Каренович | ИСТНб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка цифр \"382976421897\".                                      *");
            Console.WriteLine("* Нужно преобразовать её в матрицу 3x4 и посчитать сумму нечетных чисел.  *");
            Console.WriteLine("***************************************************************************");


            int n = 3;
            int m = 4;


            string value = "382976421897";

            DataService ds = new DataService();
            int result = ds.Calculate(n, m, value);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма нечетных элементов = " + result);
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}