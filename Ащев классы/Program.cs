using System;
using System.Linq;

namespace Ащев
{
    class Program
    {
        public static void Main()
        {
            Console.Title = "Ащев Д.Ю., группа 1, работа 7, вариант 6";
            Console.WriteLine("Работа с одномерным массивом");

            Console.WriteLine("");
            Console.WriteLine("--- 1 объект ---");

            Tarray obj1 = new Tarray();

            Console.WriteLine(obj1.GetStringArray());
            Console.WriteLine("");
            Console.WriteLine("Минимальное число:\n" + obj1.LowNumber());
            Console.WriteLine("Среднее:\n" + obj1.SrNumber());

            Console.WriteLine("");
            Console.WriteLine("--- 2 объект ---");
            Console.WriteLine("");

            Console.WriteLine("Введите размер массива: ");

            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите границы случайного числа: ");

            int[] r = Console.ReadLine().Split(' ').Select(e => Convert.ToInt32(e)).ToArray();

            int rS = (int)r[0];
            int rB = (int)r[1];

            Tarray obj2 = new Tarray(n, rS, rB);

            Console.WriteLine(obj2.GetStringArray());
            Console.WriteLine("");
            Console.WriteLine("Минимальное число:\n" + obj2.LowNumber());
            Console.WriteLine("Среднее:\n" + obj2.SrNumber());


            Console.ReadKey();
        }
    }
}
