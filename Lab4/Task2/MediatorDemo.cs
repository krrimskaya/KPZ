using System;

namespace lab4.Task2
{
    public static class MediatorDemo
    {
        public static void Run()
        {
            var runways = new Runway[2];
            for (int i = 0; i < runways.Length; i++)
                runways[i] = new Runway();

            var aircrafts = new Aircraft[3];
            for (int i = 0; i < aircrafts.Length; i++)
                aircrafts[i] = new Aircraft($"Літак {i + 1}");

            var commandCentre = new CommandCentre(runways, aircrafts);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Демонстрація шаблону Посередник (Авіадиспетчерська служба) ===");
                Console.WriteLine("1. Показати посадку літаків");
                Console.WriteLine("2. Показати зліт літаків");
                Console.WriteLine("3. Повернутися до головного меню");
                Console.Write("Оберіть опцію: ");

                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        DemonstrateLanding(aircrafts);
                        break;
                    case "2":
                        DemonstrateTakeOff(aircrafts);
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Невірний вибір. Спробуйте ще.");
                        break;
                }

                Console.WriteLine("\nНатисніть будь-яку клавішу для продовження...");
                Console.ReadKey();
            }
        }

        private static void DemonstrateLanding(Aircraft[] aircrafts)
        {
            Console.WriteLine("\n=== Демонстрація посадки ===");
            foreach (var aircraft in aircrafts)
                aircraft.RequestLand();
        }

        private static void DemonstrateTakeOff(Aircraft[] aircrafts)
        {
            Console.WriteLine("\n=== Демонстрація зльоту ===");
            foreach (var aircraft in aircrafts)
                aircraft.RequestTakeOff();
        }
    }
}