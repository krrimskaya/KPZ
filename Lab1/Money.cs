public class Money
{
    public int WholePart { get; private set; }
    public int Cents { get; private set; }

    public Money(int whole, int cents)
    {
        if (whole < 0 || cents < 0) 
            throw new ArgumentException("Ціна не може бути від’ємною!");

        WholePart = whole;
        Cents = cents;
    }

    public void ReducePrice(int whole, int cents)
    {
        int totalCents = (WholePart * 100 + Cents) - (whole * 100 + cents);
        if (totalCents < 0)
        {
            Console.WriteLine("❌ Помилка: Ціна не може бути від’ємною!");
            return;
        }
        WholePart = totalCents / 100;
        Cents = totalCents % 100;
    }

    public override string ToString()
    {
        return $"{WholePart}.{Cents:D2} грн";
    }
}
