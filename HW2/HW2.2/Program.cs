namespace HW2._2;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Необходимо ввести два числа, для проведения основных математических операций между ними (+, -, *, /).\n");

        Console.WriteLine("Введите перрвое число: ");
        var numberOne = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите второе число: ");
        var numderTwo = Convert.ToDouble(Console.ReadLine());

        if (numderTwo != 0)
        {
            Console.WriteLine($"\nРезультаты опраций над числами {numberOne} и {numderTwo}:\n" +
                              $"Сумма:\t\t{numberOne + numderTwo}\nРазность:\t{numberOne - numderTwo}\n" +
                              $"Произведение:\t{numberOne * numderTwo}\nДеление:\t{numberOne / numderTwo}");
        }
        else
        {
            Console.WriteLine("\nОшибка. Деление на 0!");
        }
        Console.ReadKey();
    }
}
