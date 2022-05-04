using System;

namespace Ащев
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ащев Д.Ю., работа 4, вариант 6";
            do
            {
                    
                int len = 0;
                do
                {
                    try
                    {
                        Console.Write("Введите количество элементов массива (от 6 до 10) = ");
                        len = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine($"Число не входит в диапозон");
                    }

                }
                while (len < 6 || len > 10);

                short[] m = new short[len];
                int i = 0;
                int len1 = len;
                double n;
                double mM = 100000;
                double mS = 0;
                double k = 0;
                double Sk;
                double V;

                while (len > 0)
                {
                    Console.Write($"{i + 1} элемент массива = ");
                    n = Convert.ToDouble(Console.ReadLine());
                    m[i] = (short)n;
                    i++;
                    len--;

                    double M = n;

                    if (M < mM)
                    {
                        mM = M;
                    }

                    mS += n;

                    Console.WriteLine("");
                }

                Console.WriteLine("==================================================");
                Console.WriteLine("");

                mS /= i;

                len = len1;
                i = 0;

                while (len > 0)
                {
                    Console.Write($"{m[i]} ");
                    i++;
                    len--;
                }

                len = len1;
                i = 0;

                while (len > 0)
                {
                    double f = (m[i] - mS) * (m[i] - mS);
                    k += f;
                    i++;
                    len--;
                }

                len = len1;

                Sk = (double)Math.Sqrt(k / (len - 1));

                V = (double)Sk / mS * 100;

                Console.WriteLine($"\n\nНаименьшее = {mM:f4}");
                Console.WriteLine($"Среднее = {mS:f4}");
                Console.WriteLine($"Коэффициент вариации = {V:f4}");
            }
            while (Console.ReadKey().Key == ConsoleKey.Spacebar);

            Environment.Exit(0);
        }
    }
}
