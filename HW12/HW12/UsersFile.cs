using System.Text.Json;

namespace HW12;

public static class UsersFile
{
    private const string FileName = "users.json";

    public static void AddDefaultUsers()
    {
        if (!File.Exists(FileName) || string.IsNullOrWhiteSpace(File.ReadAllText(FileName)))
        {
            var defaultUsers = new User[]
            {
                new User("Екатерина", 33, "ek33@mail.com"),
                new User("Владимир", 27, "vl27@mail.com")
            };

            var json = JsonSerializer.Serialize(defaultUsers);
            File.WriteAllText(FileName, json);
        }
    }

    public static void AddNewUser()
    {
        Console.WriteLine("Введите имя пользователя: ");
        var name = Console.ReadLine();
        Console.WriteLine("Введите количество полных лет: ");
        var ageStr = Console.ReadLine();
        Console.WriteLine("Введите адрес электронной почты: ");
        var email = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(ageStr) || string.IsNullOrWhiteSpace(email))
        {
            Console.WriteLine("Не все поля были заполнены.");
            return;
        }

        if (!int.TryParse(ageStr, out int age) || age < 0)
        {
            Console.WriteLine("Возраст был введен некорректно.");
            return;
        }

        var user = new User(name, age, email);

        User[] users;
        if (File.Exists(FileName))
        {
            var json = File.ReadAllText(FileName);
            users = JsonSerializer.Deserialize<User[]>(json) ?? Array.Empty<User>();
        }
        else
        {
            users = Array.Empty<User>();
        }

        var newUsers = new User[users.Length + 1];
        for (int i = 0; i < users.Length; i++) 
        {
            newUsers[i] = users[i];
        }
        newUsers[newUsers.Length - 1] = user;

        var updatedJson = JsonSerializer.Serialize(newUsers);
        File.WriteAllText(FileName, updatedJson);

        Console.WriteLine("Новый пользователь добавлен.");
    }

    public static void ShowAllUsers()
    {
        if (!File.Exists(FileName))
        {
            Console.WriteLine("Файл не найден.");
            return;
        }

        var json = File.ReadAllText(FileName);
        var users = JsonSerializer.Deserialize<User[]>(json);

        if (users == null || users.Length == 0)
        {
            Console.WriteLine("Список пуст.");
            return;
        }

        Console.WriteLine("\nСписок пользователей:");
        int i = 1;
        foreach (var user in users)
        {
            Console.WriteLine($"{i++}. {user.Name}, {user.Age} лет, e-mail: {user.Mail}");
        }
    }
}
