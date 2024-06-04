using System;

public class Money
{
    // DRY, KISS: Simple properties to hold the whole part and cents part.
    public int WholePart { get; private set; }
    public int CentsPart { get; private set; }

    // SRP: The class has a single responsibility to manage money.
    public Money(int wholePart, int centsPart)
    {
        // Fail Fast: Throwing exception if invalid input is provided.
        if (wholePart < 0 || centsPart < 0)
            throw new ArgumentException("WholePart and CentsPart cannot be negative");

        WholePart = wholePart;
        CentsPart = centsPart;
    }

    public void SetValue(int wholePart, int centsPart)
    {
        WholePart = wholePart;
        CentsPart = centsPart;
    }

    public override string ToString()
    {
        return $"{WholePart}.{CentsPart:00}";
    }
}
