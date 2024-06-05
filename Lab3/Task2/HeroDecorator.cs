public abstract class HeroDecorator : Hero
{
    protected Hero _hero;

    public HeroDecorator(Hero hero) : base(hero.Name, hero.Health, hero.Attack, hero.Defense)
    {
        _hero = hero;
    }

    public override void DisplayStats()
    {
        _hero.DisplayStats();
    }
}