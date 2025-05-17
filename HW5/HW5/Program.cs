namespace HW5;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите название книги:");
        var userTitle = Console.ReadLine();
        Console.WriteLine("Введите атора книги:");
        var userAuthor = Console.ReadLine();
        Console.WriteLine("Введите количество страниц:");
        var pages = Int32.TryParse(Console.ReadLine(), out var userPages);

        if (pages == false)
        {
            userPages = 0;
        }

        var bookUser = new BookClass(userTitle, userAuthor, userPages);
        var bookDefault = new BookClass();
        var bookTest = new BookClass("Вечныый воитель", "Майкл Муркок", 509);

        Console.WriteLine("\nИнформация о книге пользователя, перегруженный конструктор:");
        bookUser.GetDescription();

        Console.WriteLine("\nИнформация о книге, конструктор по умолчанию");
        bookDefault.GetDescription();

        Console.WriteLine("\nИнформация о книге, перегруженный конструктор:");
        bookTest.GetDescription();
    }
}
