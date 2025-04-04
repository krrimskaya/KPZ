using System;

public class WebSite : SubscriptionFactory
{
    public override ISubscription CreateSubscription()
    {
        Console.WriteLine("Виберіть тип підписки через вебсайт:");
        Console.WriteLine("1 - Домашня підписка");
        Console.WriteLine("2 - Освітня підписка");
        Console.WriteLine("3 - Преміум підписка");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                return new DomesticSubscription();
            case 2:
                return new EducationalSubscription();
            case 3:
                return new PremiumSubscription();
            default:
                Console.WriteLine("Невірний вибір!");
                return null;
        }
    }
}
