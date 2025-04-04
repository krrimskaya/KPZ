// Balaxy Laptop
public class BalaxyLaptop : ILaptop
{
    public void GetDeviceInfo()
    {
        Console.WriteLine("Balaxy Laptop: Ultra-thin laptop with premium design.");
    }
}

// Balaxy Netbook
public class BalaxyNetbook : INetbook
{
    public void GetDeviceInfo()
    {
        Console.WriteLine("Balaxy Netbook: Lightweight netbook with long battery life.");
    }
}

// Balaxy EBook
public class BalaxyEBook : IEBook
{
    public void GetDeviceInfo()
    {
        Console.WriteLine("Balaxy EBook: High-resolution e-reading device.");
    }
}

// Balaxy Smartphone
public class BalaxySmartphone : ISmartphone
{
    public void GetDeviceInfo()
    {
        Console.WriteLine("Balaxy Smartphone: Flagship smartphone with premium features.");
    }
}
