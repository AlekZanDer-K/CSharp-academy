namespace HW4._3;

internal class Program
{
    static void Main(string[] args)
    {
        var number = 0;
        do 
        {
            number -= 20;
            Console.WriteLine(number);
        }
        while (number > -100);
        
        Console.ReadKey();
    }
}
