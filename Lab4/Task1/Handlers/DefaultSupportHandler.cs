namespace Task1.SupportSystem.Handlers;

public class DefaultSupportHandler : SupportHandler
{
    public override SupportLevel HandleRequest(string question)
    {
        return SupportLevel.Unknown;
    }
}