using System;

public class Artifact : HeroDecorator
{
    public Artifact(Hero hero) : base(hero)
    {
        _hero.Health += 20;
    }

    public override void DisplayStats()
    {
        base.DisplayStats();
        Console.WriteLine($"{_hero.Name} now has an Artifact: Health +20");
    }
}