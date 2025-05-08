namespace lab4.Task2
{
    public interface IMediator
    {
        void Notify(object sender, string eventCode);
    }
}