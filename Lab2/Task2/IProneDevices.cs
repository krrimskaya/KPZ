// IProne Laptop
public class IProneLaptop : ILaptop
{
    public void GetDeviceInfo()
    {
        Console.WriteLine("IProne Laptop: High-end performance laptop.");
    }
}

// IProne Netbook
public class IProneNetbook : INetbook
{
    public void GetDeviceInfo()
    {
        Console.WriteLine("IProne Netbook: Compact and portable netbook.");
    }
}

// IProne EBook
public class IProneEBook : IEBook
{
    public void GetDeviceInfo()
    {
        Console.WriteLine("IProne EBook: Lightweight, e-reading device.");
    }
}

// IProne Smartphone
public class IProneSmartphone : ISmartphone
{
    public void GetDeviceInfo()
    {
        Console.WriteLine("IProne Smartphone: High-tech smartphone with latest features.");
    }
}
