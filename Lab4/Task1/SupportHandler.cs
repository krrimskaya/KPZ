namespace Task1.SupportSystem;

public abstract class SupportHandler
{
    protected SupportHandler? NextHandler { get; set; }

    public void SetNextHandler(SupportHandler nextHandler)
    {
        NextHandler = nextHandler;
    }

    public abstract SupportLevel HandleRequest(string question);
}