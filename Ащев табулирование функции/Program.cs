using System;
using System.Linq;

namespace Ащев_табулирование_функции
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ащев Д.Ю, работа 3, Табулирование функции";

            Console.WriteLine("Табулирование функции y = Сos^2(3/8*pi-x/4)-Cos^2(11/8*pi+x/4)");
        Repeat:
            Console.WriteLine("Введите начальное, конечное значение аргумента X и приращение dX");
            Console.WriteLine("Введите три параметра через пробел:");

            // считать строку, разделить на подстроки, поместить подстроки в массив str[]
            string[] str = Console.ReadLine().Split();


            double Xn = double.Parse(str[0]);
            double Xk = double.Parse(str[1]);
            double dX = double.Parse(str[2]);

            double pi = (double)Math.PI;
            double Yb = 0;
            double Ym = Xk;
            double Ys = 0;

            Console.WriteLine("");
            Console.WriteLine("══════════════════════════════");

            for (double i = Xn; i <= Xk;)
            {

                double f = Math.Cos((3 * pi / 8) - (i / 4)) * Math.Cos((3 * pi / 8) - (i / 4)) - Math.Cos((11 * pi / 8) + (i / 4)) * Math.Cos((11 * pi / 8) * pi + (i / 4));
                Console.WriteLine("║   X={0:f2}    ║  Y={1:f2}     ║", i, f);
                Console.WriteLine("╚══════════════╩═════════════╝");
                double B = f;
                double M = f;

                Ys += f;

                if (B > Yb)
                {
                    Yb = B;
                }
                if (M < Ym)
                {
                    Ym = M;
                }

                i += dX;
            }

            Ys = Ys / Xk;
            Console.WriteLine("======================================");
            Console.WriteLine("Наибольший y = {0:f2}", Yb);
            Console.WriteLine("Наимешний y = {0:f2}", Ym);
            Console.WriteLine("Средний y = {0:f2}", Ys);
            Console.WriteLine("======================================");
            Console.WriteLine("");

            Console.WriteLine("Нажмите Space что бы начать заново или любую кнопку что бы выйти");
            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                Console.WriteLine("");
                Console.WriteLine("======================================");
                goto Repeat;
            }
        }
    }
}


