using System;

public class Mage : Hero
{
    public Mage(string name) : base(name, 80, 20, 5) { }

    public override void DisplayStats()
    {
        Console.WriteLine($"Mage {Name} - Health: {Health}, Attack: {Attack}, Defense: {Defense}");
    }
}