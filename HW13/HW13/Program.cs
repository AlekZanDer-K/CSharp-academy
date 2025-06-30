using HW13.Enum;

namespace HW13;

internal class Program
{
    static void Main(string[] args)
    {
        var provider = new NewsProvider();

        var client1 = new Client("Владимир");
        var client2 = new Client("Жанна");

        client1.Subscribe(provider, NewsCategory.News);
        client2.Subscribe(provider, NewsCategory.Science, NewsCategory.Humor);

        provider.ShowNews(NewsCategory.News, "Операторы мобильной связи получат право включать аудиорекламу во время телефонных разговоров.");
        provider.ShowNews(NewsCategory.Science, "Берестяные грамоты — это перфокарты. Учёные нашли компьютер, созданный в Великом Новгороде тысячу лет назад.");
        provider.ShowNews(NewsCategory.Humor, "Учёные доказали, что тексты песен Стаса Михайлова создаёт советская нейросеть 1960-х.");
    }
}
