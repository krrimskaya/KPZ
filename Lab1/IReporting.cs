public interface IReporting
{
    void RegisterIncoming(IProduct product, int quantity);
    void RegisterOutgoing(IProduct product, int quantity);
    void ShowInventoryReport();
    void ShowInvoices();
}