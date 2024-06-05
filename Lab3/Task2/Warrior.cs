using System;

public class Warrior : Hero
{
    public Warrior(string name) : base(name, 100, 15, 10) { }

    public override void DisplayStats()
    {
        Console.WriteLine($"Warrior {Name} - Health: {Health}, Attack: {Attack}, Defense: {Defense}");
    }
}