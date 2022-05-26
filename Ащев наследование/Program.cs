using System;
using АщевCalcExp;
using АщевTouchCalcExp;

namespace Ащев_наследование
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ащев Д.Ю., группа 1, работа 8, вариант 6";

            Console.WriteLine("Вычисление суммы сходящегося ряда\n" +
                "ln(1 - x) = -( x/1! + x^2/2! + x^3/3! + ...\n" +
                "Элемент ряда = x^n / n\n" +
                "n = 1\n" +
                "===================================");
            double x = 0;
            do
            {
                try
                {
                    Console.Write("Введите значение x (-1, 1): ");
                    x = double.Parse(Console.ReadLine());
                }
                catch
                {
                    x = 1;
                }
            }
            while (x <= -1 || x >= 1);
            Console.Write("Введите количество элеметов ряда: ");
            int N = int.Parse(Console.ReadLine());

            CalcExp exp1 = new(x, N);
            double expand = Math.Exp(x) - 1;

            Console.WriteLine("Значения элементов ряда:");
            for (int i = 1; i <= N; i++)
                Console.WriteLine("{0,2}: {1,25:f16}", i, exp1.Taylor(x, i));

            double res = exp1.MyExp();

            Console.WriteLine("===================================");
            Console.WriteLine("Сумма ряда  : {0,20:f16}", res);
            Console.WriteLine("Math.Exp(x) : {0,20:f16}", expand);
            Console.WriteLine("Погрешность : {0,20:f16}", Math.Abs(res - expand));
            Console.WriteLine("===================================");

            Console.Write("Введите точность: ");
            double w = double.Parse(Console.ReadLine());

            TouchCalcExp exp2 = new(x, w);

            Console.WriteLine("Значения элементов ряда:");
            for (int i = 1; i <= N; i++)
                Console.WriteLine("{0,2}: {1,25:f16}", i, exp2.Taylor(x, i));

            double dop = exp2.MyExp();

            Console.WriteLine("===================================");
            Console.WriteLine("Сумма ряда  : {0,20:f16}", dop);
            Console.WriteLine("Math.Exp(x) : {0,20:f16}", expand);
            Console.WriteLine("Погрешность : {0,20:f16}", Math.Abs(dop - expand));
            Console.WriteLine("===================================");

            Console.ReadKey();
        }
    }
}