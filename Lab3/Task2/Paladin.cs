using System;

public class Paladin : Hero
{
    public Paladin(string name) : base(name, 90, 10, 15) { }

    public override void DisplayStats()
    {
        Console.WriteLine($"Paladin {Name} - Health: {Health}, Attack: {Attack}, Defense: {Defense}");
    }
}