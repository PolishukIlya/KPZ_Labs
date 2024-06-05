using System;

public class Armor : HeroDecorator
{
    public Armor(Hero hero) : base(hero)
    {
        _hero.Defense += 5;
    }

    public override void DisplayStats()
    {
        base.DisplayStats();
        Console.WriteLine($"{_hero.Name} now has extra Armor: Defense +5");
    }
}