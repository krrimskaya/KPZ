public interface IProduct
{
    string Name { get; }
    Money Price { get; }
    int Quantity { get; set; }
    void ReducePrice(int whole, int cents);
}