using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose a Hero: 1. Warrior 2. Mage 3. Paladin");
        int choice = int.Parse(Console.ReadLine());

        Hero hero;

        switch (choice)
        {
            case 1:
                hero = new Warrior("Warrior");
                break;
            case 2:
                hero = new Mage("Mage");
                break;
            case 3:
                hero = new Paladin("Paladin");
                break;
            default:
                Console.WriteLine("Invalid choice. Exiting...");
                return;
        }

        hero.DisplayStats();

        while (true)
        {
            Console.WriteLine("Choose an item to equip: 1. Armor 2. Weapon 3. Artifact 4. Exit");
            int itemChoice = int.Parse(Console.ReadLine());

            switch (itemChoice)
            {
                case 1:
                    hero = new Armor(hero);
                    break;
                case 2:
                    hero = new Weapon(hero);
                    break;
                case 3:
                    hero = new Artifact(hero);
                    break;
                case 4:
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again...");
                    continue;
            }

            hero.DisplayStats();
        }
    }
}
