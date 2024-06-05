using System;

class Program
{
    static void Main()
    {
        CharacterDirector director = new CharacterDirector();

        CharacterBuilder heroBuilder = new HeroBuilder();
        Character hero = director.BuildHero(heroBuilder);

        CharacterBuilder enemyBuilder = new EnemyBuilder();
        Character enemy = director.BuildEnemy(enemyBuilder);

        Console.WriteLine("Hero: ");
        Console.WriteLine(hero);

        Console.WriteLine("\nEnemy: ");
        Console.WriteLine(enemy);

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}