Console.Title = "Ащев Д.Ю., работа 1, Калькулятор веса";

Console.Write("Введите имя: ");
var name = Convert.ToString(Console.ReadLine());

Console.Write("Введите свой рост: ");
int height = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите свой вес: ");
int weight = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите свой пол (1 = муж | 2 = жен): ");
int m_f = Convert.ToInt32(Console.ReadLine());

int z = 0;

if (m_f == 1)
{
    int r_weight = height - 100; // Идеальный вес для мужчины
    if (weight > r_weight)
    {

        z = weight - r_weight;
        Console.WriteLine("{0} следует сбросить {1} кг!", name, z);

    }
    if (weight < r_weight)
    {

        z = r_weight - weight;
        Console.WriteLine("{0} следует набрать {1} кг!", name, z);

    }
}
else
{
    int r_weight = height - 110; // Идеальный вес для женщины
    if (weight > r_weight)
    {

        z = weight - r_weight;
        Console.WriteLine("{0} следует сбросить {1} кг!", name, z);

    }
    if (weight < r_weight)
    {

        z = r_weight - weight;
        Console.WriteLine("{0} следует набрать {1} кг!", name, z);

    }
}
Console.ReadKey();