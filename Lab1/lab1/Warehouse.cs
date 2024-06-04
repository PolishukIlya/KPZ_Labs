using System;
using System.Collections.Generic;

public class Warehouse
{
    // Composition Over Inheritance: Using a list to manage products.
    private List<Product> products = new List<Product>();

    // SRP: The class has a single responsibility to manage the inventory.
    public void AddProduct(Product product)
    {
        if (product == null)
            throw new ArgumentNullException(nameof(product));

        products.Add(product);
    }

    public void RemoveProduct(string productName)
    {
        if (string.IsNullOrWhiteSpace(productName))
            throw new ArgumentException("Product name cannot be null or empty");

        products.RemoveAll(p => p.Name == productName);
    }

    public void ListProducts()
    {
        foreach (var product in products)
        {
            Console.WriteLine(product);
        }
    }

    public Product FindProduct(string productName)
    {
        if (string.IsNullOrWhiteSpace(productName))
            throw new ArgumentException("Product name cannot be null or empty");

        return products.Find(p => p.Name == productName);
    }
}
