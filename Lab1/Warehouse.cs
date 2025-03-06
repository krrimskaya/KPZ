using System;
using System.Collections.Generic;

public class Warehouse : IWarehouse
{
    private List<IProduct> products = new List<IProduct>();

    public void AddProduct(IProduct product)
    {
        products.Add(product);
        Console.WriteLine($"✅ Товар {product.Name} додано на склад.");
    }

    public void ShowInventory()
    {
        Console.WriteLine("\n📦 Товари на складі:");
        foreach (var product in products)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine();
    }

    public IProduct FindProduct(string name)
    {
        return products.Find(p => p.Name.ToLower() == name.ToLower());
    }
}
