public class KiaomiFactory : IDeviceFactory
{
    public ILaptop CreateLaptop()
    {
        return new KiaomiLaptop();
    }

    public INetbook CreateNetbook()
    {
        return new KiaomiNetbook();
    }

    public IEBook CreateEBook()
    {
        return new KiaomiEBook();
    }

    public ISmartphone CreateSmartphone()
    {
        return new KiaomiSmartphone();
    }
}
