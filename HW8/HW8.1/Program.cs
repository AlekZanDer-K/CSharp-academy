namespace HW8._1;

internal class Program
{
    static void Main(string[] args)
    {
        char[] uslessItem = [' ', '.', ',', ':', ';', '-', '!', '?', '"'];
        
        var testString = "Ты, милок, иди яром: у дороги мина, за дорогой огород, а за ним и город у моря; иди, коли мыт!";

        if (string.IsNullOrEmpty(testString))
        {
            Console.WriteLine("Строка пустая");
        }
        else
        {
            Console.WriteLine($"Введенная строка:\n{testString}");
            var strings = testString.ToLower().Split(uslessItem, StringSplitOptions.RemoveEmptyEntries);

            var joinedStringsArray = string.Join("", strings);

            for (var i = 0; i < joinedStringsArray.Length; i++)
            {
                var left = joinedStringsArray[i];
                var right = joinedStringsArray[joinedStringsArray.Length - i - 1];
                if (left != right)
                {
                    Console.WriteLine("\nНе является палиндромом");
                    break;
                }
                else if (i > (joinedStringsArray.Length - i - 1))
                {
                    Console.WriteLine("\nЯвляется палиндромом");
                    break;
                }
                continue;
            }
        }
        Console.ReadKey();
    }
}
