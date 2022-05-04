using System;
using System.Linq;

namespace Ащев
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ащев Д.Ю., вариант 6, работа 7";
            Console.WriteLine("");

            Console.WriteLine("Введите коафициенты a, b, c, d, e, f");
            double[] k = Console.ReadLine().Split(' ').Select(e => Convert.ToDouble(e)).ToArray();

            double a = k[0];
            double b = k[1];
            double c = k[2];
            double d = k[3];
            double e = k[4];
            double f = k[5];

            int point = 0;

            if ((a == 0 && c == 0 && e / b != f / d) || (b == 0 && d == 0 && e / a != f / c))
            {
                Console.WriteLine("Ответ: 0");
            }
            else 
            {
                for (double x = -100; x <= 100;)
                {
                    for (double y = -100; y <= 100;)
                    {
                        if (a == 0) // только Y
                        {
                            if (y == (f - c * x) / d & point == 0)
                            {
                                point++;
                                Console.WriteLine($"Ответ: 4 {y}");
                            }
                        }
                        else
                        {
                            if (d == 0) // только X
                            {
                                if (x == (e - b * y) / a & point == 0)
                                {
                                    point++;
                                    Console.WriteLine($"Ответ: 3 {x}");
                                }
                            }
                            else
                            {
                                if (c * b / a - d == 0 & point == 0) // бесконечное количество решений
                                {
                                    point++;
                                    Console.WriteLine($"Ответ: 1 {-a / b} {e / b}");
                                }
                                else
                                {
                                    if (x == (e - b * y) / a & y == (f - c * x) / d & point == 0) // есть и X и Y
                                    {
                                        point++;
                                        Console.WriteLine($"Ответ: 2 {x} {y}");
                                    }
                                    else
                                    {
                                        if (a + b + c + d <= 0 & e + f <= 0 & point == 0) // бесконечное множество решений
                                        {
                                            point++;
                                            Console.WriteLine($"Ответ: 5");
                                        }
                                    }
                                }
                            }
                        }
                        y = Math.Round(y, 1) + 0.1;
                    }
                    x = Math.Round(x, 1) + 0.1;
                }
            }
            Console.ReadKey();
        }
    }
}