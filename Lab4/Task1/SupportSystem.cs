namespace Task1.SupportSystem;

public class SupportSystem
{
    private readonly SupportHandler _firstHandler;

    public SupportSystem(SupportHandler firstHandler)
    {
        _firstHandler = firstHandler;
    }

    public SupportLevel HandleRequest(string question)
    {
        return _firstHandler.HandleRequest(question);
    }
}