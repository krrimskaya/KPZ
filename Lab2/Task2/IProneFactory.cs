public class IProneFactory : IDeviceFactory
{
    public ILaptop CreateLaptop()
    {
        return new IProneLaptop();
    }

    public INetbook CreateNetbook()
    {
        return new IProneNetbook();
    }

    public IEBook CreateEBook()
    {
        return new IProneEBook();
    }

    public ISmartphone CreateSmartphone()
    {
        return new IProneSmartphone();
    }
}
