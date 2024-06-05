using System;

public class Weapon : HeroDecorator
{
    public Weapon(Hero hero) : base(hero)
    {
        _hero.Attack += 5;
    }

    public override void DisplayStats()
    {
        base.DisplayStats();
        Console.WriteLine($"{_hero.Name} now has a Weapon: Attack +5");
    }
}