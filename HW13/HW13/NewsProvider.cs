using HW13.Enum;

namespace HW13;

public class NewsProvider
{
    public event Action<NewsCategory, string> OnNews;
    public event Action<NewsCategory, string> OnScience;
    public event Action<NewsCategory, string> OnHumor;

    public void ShowNews(NewsCategory category, string message)
    {
        switch (category)
        {
            case NewsCategory.News:
                OnNews?.Invoke(category, message);
                break;
            case NewsCategory.Science:
                OnScience?.Invoke(category, message);
                break;
            case NewsCategory.Humor:
                OnHumor?.Invoke(category, message);
                break;
        }
    }
}
