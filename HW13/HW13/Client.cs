using HW13.Enum;

namespace HW13;

public class Client
{
    private string? _name;
    public string? Name
    {
        get
        {
            return _name;
        }

        set
        {
            if (string.IsNullOrWhiteSpace(value)) 
            {
                throw new ArgumentException("Имя не было введено.");
            }
                
            _name = value;
        }
    }

    public Client(string name)
    {
        Name = name;
    }

    public void Subscribe(NewsProvider provider, params NewsCategory[] categories)
    {
        foreach (var category in categories)
        {
            switch (category)
            {
                case NewsCategory.News:
                    provider.OnNews += GetCategoryAndNews;
                    break;
                case NewsCategory.Science:
                    provider.OnScience += GetCategoryAndNews;
                    break;
                case NewsCategory.Humor:
                    provider.OnHumor += GetCategoryAndNews;
                    break;
            }
        }
    }

    private void GetCategoryAndNews(NewsCategory category, string message)
    {
        Console.WriteLine($"{Name}. Новое сообщение от {category}:\n{message}");
    }
}
