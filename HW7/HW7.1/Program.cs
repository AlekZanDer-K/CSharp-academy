namespace HW7._1;

internal class Program
{
    static void Main(string[] args)
    {
        var array = new int[6];
        var random = new Random();

        Console.WriteLine("Генерируем массив чисел из 6 элементов:");

        for (int i = 0; i < 6; i++)
        {
            Console.Write((array[i] = random.Next(0,100)) + "\t");
        }

        Array.Sort(array);
        Array.Reverse(array);

        Console.WriteLine("\nСортируем элементы массива по убыванию:");

        foreach (int i in array)
        {
            Console.Write(i + "\t");
        }
    }
}
