namespace HW9._3;

internal class Program
{
    static void Main(string[] args)
    {
        var unicWordList = new Dictionary<string, int>();
        Console.WriteLine("Ведите тестовый текст:");
        var testString = Console.ReadLine();

        if (string.IsNullOrEmpty(testString))
        {
            Console.WriteLine("Текст не был введён.");
        }
        else
        {
            char[] uslessItem = [' ', '.', ',', ':', ';', '-', '!', '?', '"', '(', ')'];
            string[] strings = testString.ToLower().Split(uslessItem, StringSplitOptions.RemoveEmptyEntries);

            for (var i = 0; i < strings.Length; i++)
            {
                if (unicWordList.TryAdd(strings[i], 1))
                {
                    continue;
                }
                else
                {
                    unicWordList[strings[i]]++;
                }
            }

            Console.WriteLine("\nСписок уникальных слов и их количество повторений в тексте:");

            foreach (var word in unicWordList) 
            { 
                Console.WriteLine(word); 
            }
        }
    }
}
