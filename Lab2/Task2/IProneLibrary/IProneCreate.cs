public class IProneFactory : DeviceCreate
{
    public Laptop CreateLaptop() => new IProneLaptop();
    public Netbook CreateNetbook() => new IProneNetbook();
    public EBook CreateEBook() => new IProneEBook();
    public Smartphone CreateSmartphone() => new IProneSmartphone();
}