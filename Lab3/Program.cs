using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace FileLoggerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Select the task you want to view:");
                Console.WriteLine("1. Task 1 - Logger Example");
                Console.WriteLine("2. Task 2 - RPG Game with Decorators");
                Console.WriteLine("3. Task 3 - Bridge Pattern (Graphics Editor)");
                Console.WriteLine("4. Task 4 - Proxy Pattern (Text File Reader)");
                Console.WriteLine("5. Task 5 - LightHTML Example");
                Console.WriteLine("6. Task 6 - Lightweight HTML Parser");
                Console.WriteLine("0. Exit");
                Console.Write("\nEnter your choice: ");
                var choice = Console.ReadLine();

                if (choice == "0")
                {
                    break;
                }

                switch (choice)
                {
                    case "1":
                        Task1();
                        break;
                    case "2":
                        Task2();
                        break;
                    case "3":
                        Task3();  
                        break;
                    case "4":
                        Task4();  
                        break;
                    case "5":
                        Task5();  
                        break;
                    case "6":
                        Task6();  
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }
            }
        }

        #region Task 5: LightHTML Example

        // Task 5: LightHTML Example
        static void Task5()
        {
            // Створення елементів
            var body = new LightElementNode("body");

            var h1 = new LightElementNode("h1");
            h1.Children.Add(new LightTextNode("Welcome to LightHTML"));

            var p = new LightElementNode("p");
            p.Children.Add(new LightTextNode("This is a paragraph in LightHTML."));

            var div = new LightElementNode("div");
            div.CSClasses.Add("container");
            div.CSClasses.Add("highlight");
            div.Children.Add(new LightTextNode("This is inside a div with classes."));

            body.Children.Add(h1);
            body.Children.Add(p);
            body.Children.Add(div);

            // Виведення на екран
            Console.WriteLine(body.GetOuterHTML());
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        #endregion

        #region Task 4: Proxy Pattern (Text File Reader)

        // Task 4: Proxy Pattern (Text File Reader) - Supporting classes
        static void Task4()
        {
            // шлях до папки Task4
            string folderPath = "Task4";
            string testFilePath = Path.Combine(folderPath, "test.txt");
            string restrictedFilePath = Path.Combine(folderPath, "restricted_test.txt");

            // об'єкти для SmartTextReader
            var reader = new SmartTextReader(testFilePath);
            var checker = new SmartTextChecker(reader);
            var locker = new SmartTextReaderLocker(reader, @"^restricted.*\.txt$");

            // Прочитати файл без обмеження (test.txt)
            Console.WriteLine("Reading test.txt with logging:");
            checker.ReadFile();
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();

            // Прочитати обмежений файл (restricted_test.txt)
            Console.WriteLine("Attempting to read restricted_test.txt:");
            locker.ReadFile();
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        #endregion

        #region Task 6: Lightweight HTML Parser

        // Task 6: Lightweight HTML Parser
        static void Task6()
        {
            // текст книги
            string[] bookText = new string[] 
            {
                "The Great Book",
                "This is a paragraph with less than 20 characters.",
                "     This line starts with a space.",
                "This is a normal paragraph with a lot of characters and should be <p>."
            };

            // Створення парсера для книги
            var parser = new BookParser();
            var htmlElements = parser.ParseBookText(bookText);

            // Виведення результату
            foreach (var element in htmlElements)
            {
                Console.WriteLine(element.GetOuterHTML());
            }

            // Виведення кількості елементів у пам'яті
            Console.WriteLine("\nTotal elements in memory: " + htmlElements.Count);
            Console.ReadKey();
        }

        #endregion

        #region Task 1: Logger Example

        // Task 1: Logger Example
        static void Task1()
        {
            string filePath = "log.txt";  // Шлях до файлу для зберігання логів
            FileWriter fileWriter = new FileWriter(filePath);
            FileLoggerAdapter fileLogger = new FileLoggerAdapter(fileWriter);

            // Демонстрація логів
            fileLogger.Log("This is an info message.");
            fileLogger.Warn("This is a warning message.");
            fileLogger.Error("This is an error message.");

            Console.WriteLine("Logs have been written to the file.");
            Console.ReadKey();
        }

        #endregion

        #region Task 2: RPG Game with Decorators

        // Task 2: RPG Game with Decorators
        static void Task2()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to RPG Game!");
                Console.WriteLine("Select the task you want to see:");
                Console.WriteLine("1. Hero with Armor");
                Console.WriteLine("2. Hero with Weapon");
                Console.WriteLine("3. Hero with Artifact");
                Console.WriteLine("4. Hero with Armor, Weapon, and Artifact");
                Console.WriteLine("5. Hero with multiple items (combine all)");
                Console.WriteLine("0. Exit");
                Console.Write("\nEnter your choice: ");
                var choice = Console.ReadLine();

                if (choice == "0")
                {
                    break;
                }

                Hero hero = CreateHero();
                ApplyInventory(hero, choice);
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }

        #endregion

        #region Task 3: Bridge Pattern (Graphics Editor)

        // Task 3: Bridge Pattern (Graphics Editor)
        static void Task3()
        {
            Shape circle = new Circle(new VectorRenderer());
            Shape square = new Square(new RasterRenderer());
            Shape triangle = new Triangle(new VectorRenderer());

            Console.WriteLine("Rendering shapes:");
            circle.Draw();
            square.Draw();
            triangle.Draw();

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        #endregion

        #region Helper methods for Task 2

        static Hero CreateHero()
        {
            Console.Clear();
            Console.WriteLine("Choose your hero:");
            Console.WriteLine("1. Warrior");
            Console.WriteLine("2. Mage");
            Console.WriteLine("3. Paladin");
            var heroChoice = Console.ReadLine();

            Hero hero = heroChoice switch
            {
                "1" => new Warrior("Warrior"),
                "2" => new Mage("Mage"),
                "3" => new Paladin("Paladin"),
                _ => null
            };

            if (hero == null)
            {
                Console.WriteLine("Invalid choice! Returning to main menu.");
            }
            else
            {
                Console.WriteLine($"You have chosen: {hero.Description()}");
            }
            return hero;
        }

        static void ApplyInventory(Hero hero, string choice)
        {
            if (hero == null) return;

            List<InventoryDecorator> inventoryItems = new List<InventoryDecorator>();

            // Вибір інвентарю 
            switch (choice)
            {
                case "1":
                    inventoryItems.Add(new Armor(hero)); // броня
                    break;
                case "2":
                    inventoryItems.Add(new Weapon(hero)); // зброя
                    break;
                case "3":
                    inventoryItems.Add(new Artifact(hero)); // артефакт
                    break;
                case "4":
                    inventoryItems.Add(new Armor(hero)); 
                    inventoryItems.Add(new Weapon(hero)); 
                    inventoryItems.Add(new Artifact(hero)); 
                    break;
                case "5":
                    inventoryItems.Add(new Armor(hero)); 
                    inventoryItems.Add(new Weapon(hero)); 
                    inventoryItems.Add(new Artifact(hero));
                    break;
                default:
                    Console.WriteLine("Invalid choice! Returning to main menu.");
                    return;
            }

            foreach (var item in inventoryItems)
            {
                hero = item;
            }

            Console.Clear();
            Console.WriteLine($"Hero with chosen inventory: {hero.Description()}");
        }

        #endregion

        #region Task 1: Logger Example - Supporting classes

        public class FileWriter
        {
            private string _filePath;

            public FileWriter(string filePath)
            {
                _filePath = filePath;
            }

            public void Write(string message)
            {
                System.IO.File.AppendAllText(_filePath, message);
            }

            public void WriteLine(string message)
            {
                System.IO.File.AppendAllText(_filePath, message + Environment.NewLine);
            }
        }

        public class FileLoggerAdapter : Logger
        {
            private FileWriter _fileWriter;

            public FileLoggerAdapter(FileWriter fileWriter)
            {
                _fileWriter = fileWriter;
            }

            public new void Log(string message)
            {
                base.Log(message);  // на екран
                _fileWriter.WriteLine(message);  // в файл
            }

            public new void Error(string message)
            {
                base.Error(message); 
                _fileWriter.WriteLine(message); 
            }

            public new void Warn(string message)
            {
                base.Warn(message);  
                _fileWriter.WriteLine(message);  
            }
        }

        public class Logger
        {
            public void Log(string message)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(message);
                Console.ResetColor();
            }

            public void Error(string message)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
                Console.ResetColor();
            }

            public void Warn(string message)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(message);
                Console.ResetColor();
            }
        }

        #endregion

        #region Task 3: Bridge Pattern (Supporting classes)

        public abstract class Shape
        {
            protected IRenderer renderer;

            public Shape(IRenderer renderer)
            {
                this.renderer = renderer;
            }

            public abstract void Draw();
        }

        public interface IRenderer
        {
            void RenderShape(string shapeName);
        }

        public class VectorRenderer : IRenderer
        {
            public void RenderShape(string shapeName)
            {
                Console.WriteLine($"Drawing {shapeName} as vector");
            }
        }

        public class RasterRenderer : IRenderer
        {
            public void RenderShape(string shapeName)
            {
                Console.WriteLine($"Drawing {shapeName} as pixels");
            }
        }

        public class Circle : Shape
        {
            public Circle(IRenderer renderer) : base(renderer) { }

            public override void Draw()
            {
                renderer.RenderShape("Circle");
            }
        }

        public class Square : Shape
        {
            public Square(IRenderer renderer) : base(renderer) { }

            public override void Draw()
            {
                renderer.RenderShape("Square");
            }
        }

        public class Triangle : Shape
        {
            public Triangle(IRenderer renderer) : base(renderer) { }

            public override void Draw()
            {
                renderer.RenderShape("Triangle");
            }
        }

        #endregion

        #region Task 2: RPG Game with Decorators - Supporting classes

        public abstract class Hero
        {
            public string Name { get; set; }
            public abstract string Description();
        }

        public class Warrior : Hero
        {
            public Warrior(string name)
            {
                Name = name;
            }

            public override string Description()
            {
                return $"{Name} - Warrior, a brave fighter.";
            }
        }

        public class Mage : Hero
        {
            public Mage(string name)
            {
                Name = name;
            }

            public override string Description()
            {
                return $"{Name} - Mage, a master of magic.";
            }
        }

        public class Paladin : Hero
        {
            public Paladin(string name)
            {
                Name = name;
            }

            public override string Description()
            {
                return $"{Name} - Paladin, a holy warrior.";
            }
        }

        public abstract class InventoryDecorator : Hero
        {
            protected Hero _hero;

            public InventoryDecorator(Hero hero)
            {
                _hero = hero;
            }

            public override string Description()
            {
                return _hero.Description();
            }
        }

        public class Armor : InventoryDecorator
        {
            public Armor(Hero hero) : base(hero) { }

            public override string Description()
            {
                return base.Description() + " Equipped with Armor.";
            }
        }

        public class Weapon : InventoryDecorator
        {
            public Weapon(Hero hero) : base(hero) { }

            public override string Description()
            {
                return base.Description() + " Wielding a Sword.";
            }
        }

        public class Artifact : InventoryDecorator
        {
            public Artifact(Hero hero) : base(hero) { }

            public override string Description()
            {
                return base.Description() + " Holding a Magical Artifact.";
            }
        }

        #endregion
    }
}
