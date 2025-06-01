namespace HW7._2;

internal class Program
{
    static void Main(string[] args)
    {
        var maxValue = int.MinValue;
        var array = new int[3, 3]
        {
            {48, 19, 30},
            {74, 23, 97},
            {1, 85, -3333}
        };

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nОпределим максимальные значения каждой строки нашего массива:\n");

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (maxValue <= array[i, j]) 
                {
                    maxValue = array[i, j];
                }
            }
            Console.WriteLine($"Максимальное число в строке {i + 1} = " + maxValue);
            maxValue = int.MinValue;
        }
    }
}
