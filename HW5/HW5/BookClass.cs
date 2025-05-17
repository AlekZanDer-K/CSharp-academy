namespace HW5;

internal class BookClass
{
    private string _title;
    private string _author;
    private int _pages;

    public string Title
    {
        get
        {
            return _title;
        }

        set
        {
            if (String.IsNullOrEmpty(value) == true)
            {
                _title = "Unknown";
            }
            else
            {
                _title = value;
            }
        }
    }

    public string Author
    {
        get
        {
            return _author;
        }

        set
        {
            if (String.IsNullOrEmpty(value) == true)
            {
                _author = "Unknown";
            }
            else
            {
                _author = value;
            }
        }
    }

    public int Pages
    {
        get
        {
            return _pages;
        }

        set
        {
            if (value <= 0)
            {
                _pages = 0;
            }
            else
            {
                _pages = value;
            }
        }
    }

    public BookClass()
    {
        Title = "Unknown";
        Author = "Unknown";
        Pages = 0;
    }

    public BookClass(string title, string author, int pages)
    {
        Title = title;
        Author = author;
        Pages = pages;

    }

    public void GetDescription()
    {
        Console.WriteLine($"Название: {Title}, Автор: {Author}, Страниц: {Pages}\n");
    }
}
