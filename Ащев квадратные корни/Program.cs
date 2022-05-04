Console.Title = "Ащев Д.Ю., работа 1, Определение корней квадратного уравнения";

Repeat:
Console.Write("Введите переменные (a | b | c) через пробел: ");

int[] s = Console.ReadLine().Split(' ').Select(e => Convert.ToInt32(e)).ToArray(); // Для ввода переменных через пробел в одну строку

int a = (int) s[0];
int b = (int) s[1];
int c = (int) s[2];

double x_l;
if (a == 0)
{
    if (b != 0)
    {
        x_l = (double) c / b;

        Console.Write("Корень линейного уравнения = ");
        Console.WriteLine(x_l);

    }
    else
    {
        Console.WriteLine("Ошибка - переменная (b) равна 0");
        goto Repeat;
    }
}
else
{

    int D; // Дискриминант
    double x; // Общий корень при D = 0
    double x1; // Первый корень
    double x2; // Второй корень

    D = b * b - 4 * a * c;

    if (D >= 0)
    {
        if (D == 0)
        {

            x = (double)-b / 2 * a; // Общий корень при D = 0

            Console.Write("Корень уравнения = ");
            Console.WriteLine(x);

        }
        else
        {

            x1 = (double)((-b + Math.Sqrt(D)) / (2 * a)); // Первый корень
            x2 = (double)((-b - Math.Sqrt(D)) / (2 * a)); // Второй корень

            Console.Write("Первый корень = ");
            Console.WriteLine(x1);
            Console.Write("Второй корень = ");
            Console.WriteLine(x2);

        }
    }
    else
    {

        Console.WriteLine("Дискриминант меньше 0");
        Console.WriteLine("Что бы начать заново наберите Y, Что бы закончить N");
        string error = Console.ReadLine();
        if (error == "Y") goto Repeat; // При ошибке все начинается с ввода чисел
        if (error == "N") return; // Выход из приложения

    }
}

Console.ReadKey();