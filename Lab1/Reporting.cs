using System;
using System.Collections.Generic;

public class Reporting : IReporting
{
    private IWarehouse warehouse;
    private List<string> incomingInvoices = new List<string>();
    private List<string> outgoingInvoices = new List<string>();

    public Reporting(IWarehouse warehouse)
    {
        this.warehouse = warehouse;
    }

    public void RegisterIncoming(IProduct product, int quantity)
    {
        string invoice = $"📥 Прибуткова накладна | Товар: {product.Name}, Кількість: {quantity}, Дата: {DateTime.Now}";
        incomingInvoices.Add(invoice);
        Console.WriteLine(invoice);
    }

    public void RegisterOutgoing(IProduct product, int quantity)
    {
        if (product.Quantity < quantity)
        {
            Console.WriteLine($"❌ Недостатньо товару {product.Name} на складі! Доступно: {product.Quantity}");
            return;
        }

        product.Quantity -= quantity;
        string invoice = $"📤 Видаткова накладна | Товар: {product.Name}, Кількість: {quantity}, Дата: {DateTime.Now}";
        outgoingInvoices.Add(invoice);
        Console.WriteLine(invoice);
    }

    public void ShowInventoryReport()
    {
        Console.WriteLine("\n📊 Інвентаризаційний звіт:");
        warehouse.ShowInventory();
    }

    public void ShowInvoices()
    {
        Console.WriteLine("\n📜 Прибуткові накладні:");
        if (incomingInvoices.Count == 0)
            Console.WriteLine("⏳ Немає записів.");
        else
            foreach (var invoice in incomingInvoices) Console.WriteLine(invoice);

        Console.WriteLine("\n📜 Видаткові накладні:");
        if (outgoingInvoices.Count == 0)
            Console.WriteLine("⏳ Немає записів.");
        else
            foreach (var invoice in outgoingInvoices) Console.WriteLine(invoice);
    }
}
