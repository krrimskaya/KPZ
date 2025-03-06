using System.Collections.Generic;

public interface IWarehouse
{
    void AddProduct(IProduct product);
    void ShowInventory();
    IProduct FindProduct(string name);
}