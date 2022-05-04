using System;

namespace Ащев
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ащев Д.Ю., работа 5, вариант 6";
            int len = 0;
            do
            {
                try
                {
                    Console.Write("Введите количество элементов массива [20...30]: ");
                    len = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine($"Число не входит в диапозон");
                }

            }
            while (len < 20 || len > 30);

            Console.Write("Введите минимальное значение случайного числа: ");
            int mM = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите максимальное значение случайного числа: ");
            int mB = Convert.ToInt32(Console.ReadLine());

            float[] m = new float[len];
            Random r = new Random();

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Массив случайных чисел:");

            for (int i = 0; i < len; i++)
            {
                m[i] = r.Next(mM, mB); // присвоить случайное число из диапазона mM..mB
                Console.Write(m[i] + " ");
            }

            Console.WriteLine("\n----------------------------------------------------------------");
            Console.WriteLine("Сортировка по убыванию (Bubble 2 - for, for): ");

            Sort(m);

            for (int i = 0; i < len; i++)
            {
                Console.Write(m[i] + " ");
            }

            Console.WriteLine("\n----------------------------------------------------------------");
            Console.WriteLine("Задание по роботе с массивом");
            Console.WriteLine("Массив случайных чисел:");

            for (int i = 0; i < len; i++)
            {
                m[i] = r.Next(mM, mB); // присвоить случайное число из диапазона mM..mB
                Console.Write(m[i] + " ");
            }

            Console.WriteLine("\nОпределить количество положительных элементов, стоящих на нечётных местах");

            int result = Results(m);

            Console.Write($"Результат = {result}");

            Console.WriteLine("\n----------------------------------------------------------------");
            Console.WriteLine("Нажмите любую кнопку");
            Console.ReadKey();

        }
        

        static void Sort(float[] m)
        {
            int s = -1; // переменная для указания сортировки
            float temp;

            for (int j = 0; j < m.Length; j++)
                for (int i = 0; i < m.Length - 1; i++)
                {
                    if (m[i] * s > m[i + 1] * s)
                    {
                        temp = m[i];
                        m[i] = m[i + 1];
                        m[i + 1] = temp;

                    }
                }
        }


        static int Results(float[] m)
        {
            int k = 0;
            for (int i = 0; i < m.Length; i++) // подсчет для задания
            {
                if (m[i] > 0 & i % 2 == 0)
                {
                    k += 1;
                }
            }
            return k;
        }
    }
}
