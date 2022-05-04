using System;
using System.Linq;

namespace Ащев
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ащев Д.Ю., вариант 6, работа 6";
            Console.WriteLine("");


            Console.WriteLine("Введите через пробел координаты точки А");
            int[] A = Console.ReadLine().Split(' ').Select(e => Convert.ToInt32(e)).ToArray();
            Console.WriteLine("Введите через пробел координаты точки B");
            int[] B = Console.ReadLine().Split(' ').Select(e => Convert.ToInt32(e)).ToArray();
            Console.WriteLine("Введите через пробел координаты точки C");
            int[] C = Console.ReadLine().Split(' ').Select(e => Convert.ToInt32(e)).ToArray();

            int x1 = A[0];
            int y1 = A[1];

            int x2 = B[0];
            int y2 = B[1];

            int x3 = C[0];
            int y3 = C[1];

            double BC;
            double AB;
            double CA;
            double center;

            AB = Math.Sqrt(((y2 - y1) * (y2 - y1)) + ((x2 - x1) * (x2 - x1)));

            BC = Math.Sqrt(((y3 - y2) * (y3 - y2)) + ((x3 - x2) * (x3 - x2)));

            CA = Math.Sqrt(((y3 - y1) * (y3 - y1)) + ((x3 - x1) * (x3 - x1)));

            AB = Math.Abs(AB);
            BC = Math.Abs(BC);
            CA = Math.Abs(CA);

            double p = (AB + BC + CA) / 2;

            double s = Math.Sqrt(p * (p - AB) * (p - BC) * (p - CA));

            center = 2 * s / BC;

            Console.WriteLine($"Длина отрезка от точки A({x1}; {y1}) до прямой BC = {center:f3}");

            Console.ReadKey();

        }
    }
}
