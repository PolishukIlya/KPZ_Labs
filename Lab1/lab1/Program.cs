using System;

class Program
{
    static void Main(string[] args)
    {
        Warehouse warehouse = new Warehouse();
        Reporting reporting = new Reporting(warehouse);

        while (true)
        {
            try
            {
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Remove Product");
                Console.WriteLine("3. List Products");
                Console.WriteLine("4. Generate Receipt");
                Console.WriteLine("5. Inventory Report");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddProduct(warehouse);
                        break;
                    case 2:
                        RemoveProduct(warehouse);
                        break;
                    case 3:
                        warehouse.ListProducts();
                        break;
                    case 4:
                        GenerateReceipt(reporting);
                        break;
                    case 5:
                        reporting.InventoryReport();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    private static void AddProduct(Warehouse warehouse)
    {
        Console.Write("Enter product name: ");
        string name = Console.ReadLine();
        Console.Write("Enter unit: ");
        string unit = Console.ReadLine();
        Console.Write("Enter price (whole part): ");
        int wholePart = int.Parse(Console.ReadLine());
        Console.Write("Enter price (cents part): ");
        int centsPart = int.Parse(Console.ReadLine());
        Console.Write("Enter quantity: ");
        int quantity = int.Parse(Console.ReadLine());

        Money price = new Money(wholePart, centsPart);
        Product product = new Product(name, unit, price, quantity);
        warehouse.AddProduct(product);
    }

    private static void RemoveProduct(Warehouse warehouse)
    {
        Console.Write("Enter product name to remove: ");
        string productName = Console.ReadLine();
        warehouse.RemoveProduct(productName);
    }

    private static void GenerateReceipt(Reporting reporting)
    {
        Console.Write("Enter product name: ");
        string productName = Console.ReadLine();
        Console.Write("Enter quantity: ");
        int quantity = int.Parse(Console.ReadLine());
        Console.Write("Is it incoming (1) or outgoing (0): ");
        bool isIncoming = int.Parse(Console.ReadLine()) == 1;
        reporting.GenerateReceipt(productName, quantity, isIncoming);
    }
}
