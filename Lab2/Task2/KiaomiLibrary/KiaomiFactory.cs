public class KiaomiFactory : DeviceCreate
{
    public Laptop CreateLaptop() => new KiaomiLaptop();
    public Netbook CreateNetbook() => new KiaomiNetbook();
    public EBook CreateEBook() => new KiaomiEBook();
    public Smartphone CreateSmartphone() => new KiaomiSmartphone();
}