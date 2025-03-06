public class Product : IProduct
{
    public string Name { get; private set; }
    public string Unit { get; private set; }
    public Money Price { get; private set; }
    public int Quantity { get; set; }
    public string LastDeliveryDate { get; private set; }

    public Product(string name, string unit, Money price, int quantity, string lastDeliveryDate)
    {
        Name = name;
        Unit = unit;
        Price = price;
        Quantity = quantity;
        LastDeliveryDate = lastDeliveryDate;
    }

    public void ReducePrice(int whole, int cents)
    {
        Price.ReducePrice(whole, cents);
    }

    public override string ToString()
    {
        return $"{Name} ({Unit}) - {Quantity} од., Ціна: {Price}, Останнє завезення: {LastDeliveryDate}";
    }
}
