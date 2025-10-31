using System;
using Tyuiu.KhanikyanDK.Sprint4.Task6.V23.Lib;

namespace Tyuiu.KhanikyanDK.Sprint4.Task6.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт 4 | Выполнил: Ханикян Д. К. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт 4                                                                *");
            Console.WriteLine("* Тема: Работа со строковыми массивами                                    *");
            Console.WriteLine("* Задание 6                                                               *");
            Console.WriteLine("* Вариант 23                                                              *");
            Console.WriteLine("* Выполнил: Ханикян Давит Каренович | ИСТНб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных                                             *");
            Console.WriteLine("* [\"Microsoft\", \"Google\", \"Apple\", \"Amazon\", \"Facebook\", \"Tesla\", \"Netflix\"] *");
            Console.WriteLine("* Используя класс Array, подсчитать количество элементов, длина которых 6.*");
            Console.WriteLine("***************************************************************************");

            string[] companies = { "Microsoft", "Google", "Apple", "Amazon", "Facebook", "Tesla", "Netflix" };

            DataService ds = new DataService();
            int result = ds.Calculate(companies);

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество элементов длиной 6 символов: " + result);
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}