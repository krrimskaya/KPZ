using System;
using lab4.Task2;
using lab4.Task5;
using Task1.SupportSystem;
using Task1.SupportSystem.Handlers;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Головне меню ===");
            Console.WriteLine("1. Демонстрація системи підтримки (Chain of Responsibility)");
            Console.WriteLine("2. Демонстрація авіадиспетчерської служби (Mediator)");
            Console.WriteLine("3. Демонстрація текстового редактора (Memento)");
            Console.WriteLine("4. Вихід");
            Console.Write("Оберіть опцію: ");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    RunSupportSystemDemo();
                    break;
                case "2":
                    MediatorDemo.Run();
                    break;
                case "3":
                    TextEditorDemo.Run();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void RunSupportSystemDemo()
    {
        // Налаштування ланцюжка обробників
        var technicalHandler = new TechnicalSupportHandler();
        var billingHandler = new BillingSupportHandler();
        var accountHandler = new AccountSupportHandler();
        var generalHandler = new GeneralSupportHandler();
        var defaultHandler = new DefaultSupportHandler();

        technicalHandler.SetNextHandler(billingHandler);
        billingHandler.SetNextHandler(accountHandler);
        accountHandler.SetNextHandler(generalHandler);
        generalHandler.SetNextHandler(defaultHandler);

        var supportSystem = new SupportSystem(technicalHandler);

        Console.Clear();
        Console.WriteLine("=== Демонстрація системи підтримки ===");

        while (true)
        {
            Console.WriteLine("\nЛаскаво просимо до системи підтримки!");
            Console.WriteLine("Будь ласка, опишіть вашу проблему:");
            Console.WriteLine("(напишіть 'назад' для повернення до меню)");
            
            string? input = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Будь ласка, введіть ваш запит.");
                continue;
            }
            
            if (input.ToLower() == "назад")
            {
                return;
            }
            
            var level = supportSystem.HandleRequest(input);
            
            if (level == SupportLevel.Unknown)
            {
                Console.WriteLine("Не вдалося визначити тип проблеми. Спробуйте ще раз.");
            }
            else
            {
                Console.WriteLine($"Ваш запит оброблено на рівні: {level}");
            }
        }
    }
}