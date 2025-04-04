// Kiaomi Laptop
public class KiaomiLaptop : ILaptop
{
    public void GetDeviceInfo()
    {
        Console.WriteLine("Kiaomi Laptop: Affordable performance laptop.");
    }
}

// Kiaomi Netbook
public class KiaomiNetbook : INetbook
{
    public void GetDeviceInfo()
    {
        Console.WriteLine("Kiaomi Netbook: Budget-friendly netbook.");
    }
}

// Kiaomi EBook
public class KiaomiEBook : IEBook
{
    public void GetDeviceInfo()
    {
        Console.WriteLine("Kiaomi EBook: Efficient and durable e-reader.");
    }
}

// Kiaomi Smartphone
public class KiaomiSmartphone : ISmartphone
{
    public void GetDeviceInfo()
    {
        Console.WriteLine("Kiaomi Smartphone: Affordable smartphone with modern features.");
    }
}
