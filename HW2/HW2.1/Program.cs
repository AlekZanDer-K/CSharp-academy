namespace HW2._1;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите ваше имя: ");
        var userName = Console.ReadLine();

        Console.WriteLine("Сколько вам полных лет: ");
        var userAge = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Какой у вас рост (в метрах): ");
        var userHeight = Convert.ToDouble(Console.ReadLine());

        if (userName != "" && userAge > 0 && userHeight > 0)
        {
            Console.WriteLine($"\nПривет, {userName}!\n\tВаш возраст: {userAge} лет.\n\t\tВаш рост: {userHeight} м.");
        }
        else
        {
            Console.WriteLine("\nНекорректно введены данные!");
        }

        Console.ReadKey();
    }
}
