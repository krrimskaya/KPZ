using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            // Головне меню для вибору завдання
            Console.WriteLine("\nВиберіть завдання:");
            Console.WriteLine("1 - Завдання 1: Придбання підписки");
            Console.WriteLine("2 - Завдання 2: Створення девайсів");
            Console.WriteLine("3 - Завдання 3: Одинак (Singleton)");
            Console.WriteLine("4 - Завдання 4: Прототип (Клонування вірусів)");
            Console.WriteLine("5 - Завдання 5: Будівельник");
            Console.WriteLine("6 - Вийти");

            int taskChoice = GetValidInput(1, 6); // Перевірка введення

            if (taskChoice == 6)
            {
                break; // Вихід з програми
            }

            if (taskChoice == 5)
            {
                // Завдання 5: Будівельник
                BuilderTask();
            }
            else if (taskChoice == 4)
            {
                // Завдання 4: Прототип (Клонування вірусів)
                PrototypeTask();
            }
            else if (taskChoice == 1)
            {
                // Завдання 1: Придбання підписки
                SelectSubscriptionTask();
            }
            else if (taskChoice == 2)
            {
                // Завдання 2: Створення девайсів
                SelectDeviceFactory();
            }
            else if (taskChoice == 3)
            {
                // Завдання 3: Одинак (Singleton)
                SingletonTask();
            }
        }
    }

    // Завдання 5: Демонстрація патерну Будівельник
    static void BuilderTask()
    {
        // Створення героя
        Hero hero = (Hero)new HeroBuilder()
            .SetName("Odette")
            .SetHeight("5'8\"")
            .SetBuild("Slim")
            .SetHairColor("Blonde")
            .SetEyeColor("Blue")
            .SetOutfit("White Swan Dress")
            .AddToInventory("Feathered Crown")
            .AddGoodDeed("Rescue the prince")
            .AddGoodDeed("Defeat the sorcerer")
            .Build();

        // Створення ворога
        Enemy enemy = (Enemy)new EnemyBuilder()
            .SetName("Rothbart")
            .SetHeight("6'2\"")
            .SetBuild("Muscular")
            .SetHairColor("Black")
            .SetEyeColor("Red")
            .SetOutfit("Dark Robe")
            .AddToInventory("Magic Staff")
            .AddEvilDeed("Cast a spell on Odette")
            .AddEvilDeed("Kidnap the princess")
            .Build();

        // Виведення інформації про героя та ворога
        Console.WriteLine("Hero:");
        hero.ShowInfo();
        Console.WriteLine("\nEnemy:");
        enemy.ShowInfo();
    }

    // Завдання 4: Демонстрація патерну Прототип
    static void PrototypeTask()
    {
        // Створюємо базові віруси
        Virus parentVirus = new Virus("Virus Alpha", "Flu", 0.5, 2);
        Virus child1 = new Virus("Virus Beta", "Cold", 0.3, 1);
        Virus child2 = new Virus("Virus Gamma", "Cold", 0.2, 1);

        // Додаємо дітей до батька
        parentVirus.AddChild(child1);
        parentVirus.AddChild(child2);

        // Клонуємо батька
        Virus clonedVirus = (Virus)parentVirus.Clone();

        // Показуємо інформацію про оригінальний та клонований вірус
        Console.WriteLine("Original Virus:");
        parentVirus.ShowInfo();

        Console.WriteLine("\nCloned Virus:");
        clonedVirus.ShowInfo();
    }

    // Завдання 1: Вибір підписки
    static void SelectSubscriptionTask()
    {
        Console.WriteLine("\nВиберіть спосіб придбання підписки:");
        Console.WriteLine("1 - Вебсайт");
        Console.WriteLine("2 - Мобільний додаток");
        Console.WriteLine("3 - Дзвінок менеджера");

        int methodChoice = GetValidInput(1, 3);

        SubscriptionFactory factory;

        switch (methodChoice)
        {
            case 1:
                factory = new WebSite();
                break;
            case 2:
                factory = new MobileApp();
                break;
            case 3:
                factory = new ManagerCall();
                break;
            default:
                Console.WriteLine("Невірний вибір способу придбання!");
                return;
        }

        // Створюємо підписку через вибрану фабрику
        ISubscription subscription = factory.CreateSubscription();
        PrintSubscriptionDetails(subscription);
    }

    // Завдання 2: Вибір фабрики девайсів
    static void SelectDeviceFactory()
    {
        Console.WriteLine("\nВиберіть бренд девайсу:");
        Console.WriteLine("1 - IProne");
        Console.WriteLine("2 - Kiaomi");
        Console.WriteLine("3 - Balaxy");

        int brandChoice = GetValidInput(1, 3);

        IDeviceFactory factory;

        switch (brandChoice)
        {
            case 1:
                factory = new IProneFactory();
                break;
            case 2:
                factory = new KiaomiFactory();
                break;
            case 3:
                factory = new BalaxyFactory();
                break;
            default:
                Console.WriteLine("Невірний вибір бренду!");
                return;
        }

        // Створюємо девайс через вибрану фабрику
        CreateDevice(factory);
    }

    // Створення девайсів через вибрану фабрику
    static void CreateDevice(IDeviceFactory factory)
    {
        var laptop = factory.CreateLaptop();
        var netbook = factory.CreateNetbook();
        var ebook = factory.CreateEBook();
        var smartphone = factory.CreateSmartphone();

        // Виведення інформації про девайси
        laptop.GetDeviceInfo();
        netbook.GetDeviceInfo();
        ebook.GetDeviceInfo();
        smartphone.GetDeviceInfo();
    }

    // Завдання 3: Демонстрація патерну Singleton
    static void SingletonTask()
    {
        Console.WriteLine("\nЗавдання 3: Одинак (Singleton)");

        // Перевірка, чи працює одинак
        Authenticator auth1 = Authenticator.GetInstance();
        Authenticator auth2 = Authenticator.GetInstance();

        // Перевірка, чи це один і той самий екземпляр
        Console.WriteLine($"Один і той самий екземпляр: {Object.ReferenceEquals(auth1, auth2)}");

        // Використовуємо метод аутентифікації
        auth1.Authenticate("user1", "password123");
    }

    // Перевірка введення числа
    static int GetValidInput(int min, int max)
    {
        int choice;
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out choice) && choice >= min && choice <= max)
            {
                break;
            }
            else
            {
                Console.WriteLine($"Введіть число від {min} до {max}:");
            }
        }
        return choice;
    }

    // Виведення деталей підписки
    static void PrintSubscriptionDetails(ISubscription subscription)
    {
        Console.WriteLine("\nДеталі підписки:");
        Console.WriteLine($"Щомісячна плата: {subscription.MonthlyFee} USD");
        Console.WriteLine($"Мінімальний період: {subscription.MinimumPeriod} місяців");
        Console.WriteLine("Канали: " + string.Join(", ", subscription.Channels));
        Console.WriteLine("Особливості: " + string.Join(", ", subscription.Features));
    }
}
