namespace HW4._1;

internal class Program
{
    static void Main(string[] args)
    {
        var countWhile = 0;
        var countDoWhile = 0;

        Random random = new Random();
        var array = new int[10];

        for (var i = 0; i < 10; i++) 
        { 
            array[i] = random.Next(0,100); 
        }

        Console.WriteLine("Перебор массива при помощи Foreach: ");

        foreach (var item in array)
        {
            Console.Write($"{item} ");
        }

        Console.WriteLine("\n\nПеребор массива при помощи For: ");

        for (var i = 0; i < 10; i++) 
        { 
            Console.Write($"{array[i]} "); 
        }

        Console.WriteLine("\n\nПеребор массива при помощи While: ");
        
        while (countWhile != 10)
        {
            Console.Write($"{array[countWhile]} ");
            countWhile++;
        }

        Console.WriteLine("\n\nПеребор массива при помощи Do While: ");

        do
        {
            Console.Write($"{array[countDoWhile]} ");
            countDoWhile++;
        }
        while (countDoWhile != 10);

        Console.ReadKey();
    }
}
