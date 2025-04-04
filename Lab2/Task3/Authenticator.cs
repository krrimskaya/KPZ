using System;

public class Authenticator
{
    // Поле для зберігання єдиного екземпляра
    private static Authenticator instance;

    // Об'єкт для синхронізації доступу до екземпляра в багатопоточному середовищі
    private static readonly object lockObject = new object();

    // Приватний конструктор, щоб заборонити створення екземплярів зовні
    private Authenticator() { }

    // Статичний метод для доступу до єдиного екземпляра
    public static Authenticator GetInstance()
    {
        // Перевірка, чи вже існує екземпляр
        if (instance == null)
        {
            // Блокування доступу, щоб лише один потік міг створити екземпляр
            lock (lockObject)
            {
                // Перевірка ще раз, оскільки інші потоки могли вже створити екземпляр
                if (instance == null)
                {
                    instance = new Authenticator();
                }
            }
        }

        return instance;
    }

    // Приклад методу, який може бути в класі Authenticator
    public void Authenticate(string username, string password)
    {
        Console.WriteLine($"Аутентифікація для користувача {username}...");
        // Логіка аутентифікації
    }
}
