using System;
using System.IO;
using System.Threading.Tasks;

namespace Ащев
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.Title = "Ащев Д.Ю., вариант 6, работа 5";
            Console.WriteLine("");

            Answer();

            Console.WriteLine("=============================");
            Console.WriteLine("");

            string path = "check_rubles.txt";

            using (StreamReader reader = new StreamReader(path))
            {
                string text = await reader.ReadToEndAsync();
                Console.WriteLine(text);
            }

            Console.WriteLine("");
            Console.WriteLine("=============================");
            Console.WriteLine("");
            Console.WriteLine("Данные для проверки сверху");
            Console.ReadKey();

        }

        static void Answer()
        {
            do
            {
            Console.Write("Введите число: ");
                int l = 1;
                do
                {
                    try
                    {
                        int n = int.Parse(Console.ReadLine());

                        string s = "рублей";

                        if (n % 10 == 1) s = "рубль";

                        if (n % 10 >= 2 && n % 10 <= 4) s = "рубля";

                        if (n % 100 >= 11 & n % 100 <= 20) s = "рублей";


                        Console.WriteLine($"Ваша сумма = {n} {s}");

                        Console.WriteLine("");
                        Console.WriteLine("Нажмите Enter что бы начать заново или любую кнопку что бы показать список");
                        Console.WriteLine("");
                    }
                    catch
                    {
                        Console.Write("Введите существующее число: ");
                        l = 0;
                    }
                }
                while (l == 0);

            }
            while(Console.ReadKey().Key == ConsoleKey.Enter);

        }
    }
}
