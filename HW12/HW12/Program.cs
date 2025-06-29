/*
Необходимо создать консольное приложение, которое позволяет управлять списком пользователей. Каждая запись о пользователе должна включать:
Имя (строка).
Возраст (целое число).
Электронную почту (строка).
Программа должна предоставлять следующий функционал:
Добавить пользователя.
Показать всех пользователей.
Сохранить список пользователей в файл с помощью сериализации (JSON).
Загрузить список пользователей из файла с помощью десериализации (JSON).
Завершить программу.

Технические требования:
Для сериализации и десериализации используйте класс JsonSerializer из пространства имен System.Text.Json.
Список пользователей храните только в файле.
Сохранение и загрузка данных производятся из файла users.json.
При запуске программы добавить сразу несколько пользователей и сохранить в файл.
*/


using System.ComponentModel;
using System.Text.Json;

namespace HW12;

internal class Program
{
    static void Main(string[] args)
    {
       UsersFile.AddDefaultUsers();

            while (true)
        {
            Console.Clear();

            Console.WriteLine("Меню:\n" +
                              "1. Добавить пользователя\n" +
                              "2. Показать всех пользователей\n" +
                              "3. Выход\n" +
                              "Выберите необходимый пункт: ");

            switch (Console.ReadLine())
            {
                case "1":
                    UsersFile.AddNewUser();
                    Console.WriteLine("\nНажмите любую клавишу, чтобы продолжить.");
                    Console.ReadKey();
                    break;
                case "2":
                    UsersFile.ShowAllUsers();
                    Console.WriteLine("\nНажмите любую клавишу, чтобы продолжить.");
                    Console.ReadKey();
                    break;
                case "3":
                    Console.WriteLine("Завершение работы.");
                    return;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте ещё раз.");
                    Console.ReadKey();
                    break;
            }

            Console.WriteLine();
        }
    }
}
