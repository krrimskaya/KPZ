using System;

class Program
{
    static IWarehouse warehouse = new Warehouse();
    static IReporting reporting = new Reporting(warehouse);

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== 📦 Управління складом ===");
            Console.WriteLine("1️⃣ Додати товар");
            Console.WriteLine("2️⃣ Переглянути склад");
            Console.WriteLine("3️⃣ Зменшити ціну товару");
            Console.WriteLine("4️⃣ Зареєструвати надходження товару");
            Console.WriteLine("5️⃣ Зареєструвати відвантаження товару");
            Console.WriteLine("6️⃣ Переглянути всі накладні");
            Console.WriteLine("7️⃣ Звіт по складу");
            Console.WriteLine("8️⃣ Тестування функціональності");
            Console.WriteLine("9️⃣ Вихід");
            Console.Write("🛠 Виберіть опцію: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddProduct();
                    break;
                case "2":
                    warehouse.ShowInventory();
                    break;
                case "3":
                    ReduceProductPrice();
                    break;
                case "4":
                    RegisterIncomingGoods();
                    break;
                case "5":
                    RegisterOutgoingGoods();
                    break;
                case "6":
                    reporting.ShowInvoices();
                    break;
                case "7":
                    reporting.ShowInventoryReport();
                    break;
                case "8":
                    RunTests();  // Додаємо тестування як окремий пункт меню
                    break;
                case "9":
                    Console.WriteLine("👋 До побачення!");
                    return;
                default:
                    Console.WriteLine("❌ Невірний вибір! Спробуйте ще раз.");
                    break;
            }
        }
    }

    // Тестування
    static void RunTests()
    {
        Console.WriteLine("\n--- Запуск тестів ---");
        Test_AddProducts();
        Test_ReduceProductPrice();
        Test_RegisterIncomingGoods();
        Test_RegisterOutgoingGoods();
        Test_ShowInventoryReport();
        Test_ShowInvoices();
        Console.WriteLine("\n--- Тестування завершено ---");
    }

    // Тест 1: Додавання товарів
    static void Test_AddProducts()
    {
        Console.WriteLine("\n--- Тест 1: Додавання товару ---");
        AddProduct();
    }

    // Тест 2: Зменшення ціни товару
    static void Test_ReduceProductPrice()
    {
        Console.WriteLine("\n--- Тест 2: Зменшення ціни товару ---");
        ReduceProductPrice();
    }

    // Тест 3: Реєстрація надходження товару
    static void Test_RegisterIncomingGoods()
    {
        Console.WriteLine("\n--- Тест 3: Реєстрація надходження товару ---");
        RegisterIncomingGoods();
    }

    // Тест 4: Реєстрація відвантаження товару
    static void Test_RegisterOutgoingGoods()
    {
        Console.WriteLine("\n--- Тест 4: Реєстрація відвантаження товару ---");
        RegisterOutgoingGoods();
    }

    // Тест 5: Перегляд складу
    static void Test_ShowInventoryReport()
    {
        Console.WriteLine("\n--- Тест 5: Перегляд складу ---");
        reporting.ShowInventoryReport();
    }

    // Тест 6: Перегляд накладних
    static void Test_ShowInvoices()
    {
        Console.WriteLine("\n--- Тест 6: Перегляд накладних ---");
        reporting.ShowInvoices();
    }

    // Реалізація додавання товарів
    static void AddProduct()
    {
        Console.Write("\n📌 Введіть назву товару: ");
        string name = "Яблуко";

        Console.Write("📌 Введіть одиницю виміру: ");
        string unit = "кг";

        Console.Write("📌 Введіть ціну (грн, коп): ");
        int whole = 10;
        int cents = 50;

        Console.Write("📌 Введіть кількість: ");
        int quantity = 100;

        Console.Write("📌 Введіть дату останнього завезення: ");
        string date = "2025-03-06";

        warehouse.AddProduct(new Product(name, unit, new Money(whole, cents), quantity, date));
    }

    // Реалізація зменшення ціни товару
    static void ReduceProductPrice()
    {
        Console.Write("\n🔍 Введіть назву товару для зниження ціни: ");
        string name = "Яблуко";
        IProduct product = warehouse.FindProduct(name);

        if (product == null) return;

        Console.Write("📌 На скільки зменшити ціну (грн, коп): ");
        string[] priceParts = new string[] { "2", "00" };
        product.ReducePrice(int.Parse(priceParts[0]), int.Parse(priceParts[1]));
    }

    // Реалізація реєстрації надходження товару
    static void RegisterIncomingGoods()
    {
        Console.Write("\n🔍 Введіть назву товару: ");
        string name = "Яблуко";

        IProduct product = warehouse.FindProduct(name);
        if (product == null)
        {
            Console.WriteLine("❌ Товар не знайдено!");
            return;
        }

        Console.Write("📌 Введіть кількість надходження: ");
        int quantity = 50;

        product.Quantity += quantity;
        reporting.RegisterIncoming(product, quantity);
    }

    // Реалізація реєстрації відвантаження товару
    static void RegisterOutgoingGoods()
    {
        Console.Write("\n🔍 Введіть назву товару: ");
        string name = "Яблуко";

        IProduct product = warehouse.FindProduct(name);
        if (product == null)
        {
            Console.WriteLine("❌ Товар не знайдено!");
            return;
        }

        Console.Write("📌 Введіть кількість для відвантаження: ");
        int quantity = 30;

        reporting.RegisterOutgoing(product, quantity);
    }

    // Виведення звіту по складу
    static void ShowInventoryReport()
    {
        reporting.ShowInventoryReport();
    }

    // Виведення всіх накладних
    static void ShowInvoices()
    {
        reporting.ShowInvoices();
    }
}
