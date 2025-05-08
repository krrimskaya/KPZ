namespace Task1.SupportSystem.Handlers;

public class GeneralSupportHandler : SupportHandler
{
    public override SupportLevel HandleRequest(string question)
    {
        if (question.Contains("загальн", StringComparison.OrdinalIgnoreCase) || 
            question.Contains("питання", StringComparison.OrdinalIgnoreCase) || 
            question.Contains("допомог", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Ваш запит передано до загальної підтримки.");
            return SupportLevel.General;
        }
        
        return NextHandler?.HandleRequest(question) ?? SupportLevel.Unknown;
    }
}