namespace Task1.SupportSystem.Handlers;

public class AccountSupportHandler : SupportHandler
{
    public override SupportLevel HandleRequest(string question)
    {
        if (question.Contains("акаунт", StringComparison.OrdinalIgnoreCase) || 
            question.Contains("логін", StringComparison.OrdinalIgnoreCase) || 
            question.Contains("пароль", StringComparison.OrdinalIgnoreCase) || 
            question.Contains("реєстрація", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Ваш запит передано до підтримки акаунтів.");
            return SupportLevel.Account;
        }
        
        return NextHandler?.HandleRequest(question) ?? SupportLevel.Unknown;
    }
}