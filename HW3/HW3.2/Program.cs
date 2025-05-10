namespace HW3._2;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите два булевых значения true или falase\n" +
                          "для проведения логических операций между ними: & (И), | (ИЛИ), ^ (исключающее ИЛИ), ! (НЕ)\n");

        Console.WriteLine("Введите первое значение p: ");
        var booleanOneStr = Console.ReadLine();
        Console.WriteLine("Введите второе значение q: ");
        var booleanTwoStr = Console.ReadLine();

        if (booleanOneStr == "" || booleanTwoStr == "")
        {
            Console.WriteLine("Значение не были введены частично или полностью!");
        }
        else
        {
            if (booleanOneStr == "true" || booleanOneStr == "false")
            {
                if (booleanTwoStr == "true" || booleanTwoStr == "false")
                {
                    var booleanOne = Convert.ToBoolean(booleanOneStr);
                    var booleanTwo = Convert.ToBoolean(booleanTwoStr);

                    Console.WriteLine($"_____________________________________________\n" +
                                      $"p\tq\tp&q\tp|q\tp^q\t!p\n" +
                                      $"_____________________________________________\n" +
                                      $"{booleanOne}\t{booleanTwo}\t{booleanOne && booleanTwo}\t" +
                                      $"{booleanOne || booleanTwo}\t{booleanOne ^ booleanTwo}\t{!booleanOne}\n" +
                                      $"_____________________________________________");
                }
                else
                {
                    Console.WriteLine("Значения введены некорректно");
                }
            }
            else
            {
                Console.WriteLine("Значения введены некорректно");
            }
        }
        Console.ReadKey();
    }
}
