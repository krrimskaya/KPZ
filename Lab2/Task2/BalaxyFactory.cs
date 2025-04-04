public class BalaxyFactory : IDeviceFactory
{
    public ILaptop CreateLaptop()
    {
        return new BalaxyLaptop();
    }

    public INetbook CreateNetbook()
    {
        return new BalaxyNetbook();
    }

    public IEBook CreateEBook()
    {
        return new BalaxyEBook();
    }

    public ISmartphone CreateSmartphone()
    {
        return new BalaxySmartphone();
    }
}
