using System;

namespace lab4.Task5
{
    public static class TextEditorDemo
    {
        public static void Run()
        {
            var editor = new TextEditor("Початковий текст");
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Текстовий редактор (Memento) ===");
                Console.WriteLine($"Поточний текст: {editor.GetContent()}");
                Console.WriteLine("\n1. Редагувати текст");
                Console.WriteLine("2. Скасувати зміни");
                Console.WriteLine("3. Повернутися до меню");
                Console.Write("Оберіть дію: ");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Введіть новий текст: ");
                        var newText = Console.ReadLine();
                        editor.Edit(newText);
                        break;
                    case "2":
                        editor.Undo();
                        Console.WriteLine("Зміни скасовано!");
                        Console.ReadKey();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Невірний вибір!");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}