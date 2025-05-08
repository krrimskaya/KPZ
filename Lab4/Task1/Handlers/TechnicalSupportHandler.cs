namespace Task1.SupportSystem.Handlers;

public class TechnicalSupportHandler : SupportHandler
{
    public override SupportLevel HandleRequest(string question)
    {
        if (question.Contains("не працює", StringComparison.OrdinalIgnoreCase) || 
            question.Contains("помилка", StringComparison.OrdinalIgnoreCase) || 
            question.Contains("техніч", StringComparison.OrdinalIgnoreCase) || 
            question.Contains("злама", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Ваш запит передано до технічної підтримки.");
            return SupportLevel.Technical;
        }
        
        return NextHandler?.HandleRequest(question) ?? SupportLevel.Unknown;
    }
}