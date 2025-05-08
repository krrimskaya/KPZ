using KPZ.Lab3.Task5;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Демонстрація HTML-елементів ===");
        Console.WriteLine("Створюємо структуру документу...\n");
        
        // Створення структури документу
        var div = new LightElementNode("div", isBlockElement: true);
        div.CssClasses.Add("container");
        
        var heading = new LightElementNode("h1");
        heading.Children.Add(new LightTextNode("Hello World"));
        
        var paragraph = new LightElementNode("p");
        paragraph.Children.Add(new LightTextNode("This is a paragraph"));
        
        div.Children.Add(heading);
        div.Children.Add(paragraph);

        Console.WriteLine("Згенерований HTML:");
        Console.WriteLine("-------------------");
        Console.WriteLine(div.GetOuterHTML());
        Console.WriteLine("-------------------\n");

        Console.WriteLine("=== Демонстрація завантаження зображень ===");
        
        // Тестування завантаження локального зображення
        Console.WriteLine("\nСпроба завантажити локальне зображення:");
        string localImagePath = "local_photo.jpeg";
        Console.WriteLine($"Шлях: {Path.GetFullPath(localImagePath)}");
        
        try
        {
            var localImage = new LightImageNode(
                localImagePath, 
                new FileSystemImageStrategy());
            
            Console.WriteLine("\nРезультат (перші 100 символів):");
            Console.WriteLine(localImage.GetOuterHTML().Substring(0, 100) + "...");
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nПомилка: {ex.Message}");
            Console.ResetColor();
            Console.WriteLine("Рекомендація: перевірте чи файл існує за вказаним шляхом");
        }

        // Тестування завантаження мережевого зображення
        Console.WriteLine("\nСпроба завантажити зображення з інтернету:");
        string imageUrl = "https://i.pinimg.com/736x/65/63/00/65630057c503ea73085ed744c3467dbb.jpg";
        Console.WriteLine($"URL: {imageUrl}");
        
        try
        {
            var webImage = new LightImageNode(
                imageUrl,
                new NetworkImageStrategy());
            
            Console.WriteLine("\nУспішно завантажено!");
            Console.WriteLine("Тип зображення: " + webImage.GetOuterHTML().Split(';')[0].Replace("data:", ""));
            Console.WriteLine("\nПерші 100 символів base64:");
            string base64 = webImage.GetOuterHTML().Split(',')[1];
            Console.WriteLine(base64.Substring(0, Math.Min(100, base64.Length)) + "...");
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nПомилка: {ex.Message}");
            Console.ResetColor();
            Console.WriteLine("Рекомендація: перевір URL");
        }

        Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
        Console.ReadKey();
    }
}