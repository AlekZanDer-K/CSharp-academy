namespace HW9._2;

internal class Program
{
    static void Main(string[] args)
    {
        var foodstuff = new Dictionary<string, double>
        {
            ["Молоко"] = 2.50,
            ["Яйца куриные"] = 3.87,
            ["Бананы"] = 5.49,
            ["Яблоко"] = 4.89,
            ["Форель"] = 22.15,
            ["Лаваш"] = 2.39,
            ["Груша"] = 6.59,
            ["Питайя"] = 16.99,
            ["Зефир"] = 4.99,
            ["Халва"] = 3.89
        };

        foreach (var food in foodstuff)
        {
            Console.WriteLine("{0} - {1} бел.руб", food.Key, food.Value);
        }

        Console.Write("\nВведите наименование продукта, который хотите найти: ");

        var targetFood = Console.ReadLine();
        if (string.IsNullOrEmpty(targetFood))
        {
            Console.WriteLine("Ничего не найдено");
        }
        else
        {
            var i = 0;
            Console.WriteLine($"\nРезультаты поиска по {targetFood}:");
            foreach (var food in foodstuff)
            {
                if (food.Key.ToLower().Trim().Contains(targetFood.ToLower().Trim()))
                {
                    Console.WriteLine($"{food.Key} {food.Value}");
                    i++;
                }
            }

            if (i == 0)
            {
                Console.WriteLine("Ничего не найдено");
            }
        }

        Console.WriteLine("\nСРОЧНО повысить цены на 10%!:\n");

        foreach (var food in foodstuff)
        {
            Console.WriteLine("{0} - {1:f2} бел.руб", food.Key, foodstuff[food.Key] = food.Value * 1.1);
        }
    }
}
