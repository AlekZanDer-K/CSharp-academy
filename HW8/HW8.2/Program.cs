using System.Text;

namespace HW8._2;

internal class Program
{
    static void Main(string[] args)
    {
        var testString = "HelLo World today is a good DAY!";
        var modifyString = new StringBuilder(testString);
        if (string.IsNullOrEmpty(testString))
        {
            Console.WriteLine("Пустая строка");
        }
        else
        {
            modifyString.Replace(" ", "");
            Console.WriteLine(modifyString.ToString());
        }
        Console.ReadKey();
    }
}
