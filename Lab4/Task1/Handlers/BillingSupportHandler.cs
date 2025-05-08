namespace Task1.SupportSystem.Handlers;

public class BillingSupportHandler : SupportHandler
{
    public override SupportLevel HandleRequest(string question)
    {
        if (question.Contains("рахунок", StringComparison.OrdinalIgnoreCase) || 
            question.Contains("оплата", StringComparison.OrdinalIgnoreCase) || 
            question.Contains("платіж", StringComparison.OrdinalIgnoreCase) || 
            question.Contains("гроші", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Ваш запит передано до фінансової підтримки.");
            return SupportLevel.Billing;
        }
        
        return NextHandler?.HandleRequest(question) ?? SupportLevel.Unknown;
    }
}