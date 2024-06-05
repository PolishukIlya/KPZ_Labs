public class BalaxyCreate : DeviceCreate
{
    public Laptop CreateLaptop() => new BalaxyLaptop();
    public Netbook CreateNetbook() => new BalaxyNetbook();
    public EBook CreateEBook() => new BalaxyEBook();
    public Smartphone CreateSmartphone() => new BalaxySmartphone();
}