using System;

public class Product
{
    // DRY, KISS: Simple properties for product details.
    public string Name { get; private set; }
    public string Unit { get; private set; }
    public Money Price { get; private set; }
    public int Quantity { get; private set; }

    // SRP: The class has a single responsibility to manage product details.
    public Product(string name, string unit, Money price, int quantity)
    {
        // Fail Fast: Throwing exception if invalid input is provided.
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name cannot be null or empty");

        if (string.IsNullOrWhiteSpace(unit))
            throw new ArgumentException("Unit cannot be null or empty");

        if (price == null)
            throw new ArgumentNullException(nameof(price));

        if (quantity < 0)
            throw new ArgumentException("Quantity cannot be negative");

        Name = name;
        Unit = unit;
        Price = price;
        Quantity = quantity;
    }

    // YAGNI: Only the necessary method to decrease the price is implemented.
    public void DecreasePrice(int amountInCents)
    {
        int totalCents = Price.WholePart * 100 + Price.CentsPart - amountInCents;
        Price.SetValue(totalCents / 100, totalCents % 100);
    }

    public override string ToString()
    {
        return $"{Name}, {Unit}, {Price}, {Quantity}";
    }
}
