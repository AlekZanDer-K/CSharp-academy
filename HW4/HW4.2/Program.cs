namespace HW4._2;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Все двухзначные числа кратные 5:\n");

        for (var i = -95; i < 100; i+=5) 
        { 
           if ( i % 5 == 0 && (i <= -10 || i >= 10))
           {
               Console.Write($"{i} ");
           }
           else
           {
               continue;
           }
        }

        Console.ReadKey();
    }
}
