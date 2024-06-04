using System;

public class Reporting
{
    private readonly Warehouse warehouse;

    // DIP: Depend on abstractions (interface) instead of concrete implementations.
    public Reporting(Warehouse warehouse)
    {
        this.warehouse = warehouse ?? throw new ArgumentNullException(nameof(warehouse));
    }

    // SRP: The class has a single responsibility to manage reporting.
    public void GenerateReceipt(string productName, int quantity, bool isIncoming)
    {
        if (string.IsNullOrWhiteSpace(productName))
            throw new ArgumentException("Product name cannot be null or empty");

        if (quantity < 0)
            throw new ArgumentException("Quantity cannot be negative");

        var product = warehouse.FindProduct(productName);
        if (product == null)
        {
            Console.WriteLine("Product not found.");
            return;
        }

        if (isIncoming)
        {
            Console.WriteLine($"Incoming receipt: {quantity} of {productName} at {product.Price} each");
        }
        else
        {
            Console.WriteLine($"Outgoing receipt: {quantity} of {productName} at {product.Price} each");
        }
    }

    public void InventoryReport()
    {
        Console.WriteLine("Inventory Report:");
        warehouse.ListProducts();
    }
}
