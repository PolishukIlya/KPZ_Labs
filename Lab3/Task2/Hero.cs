public abstract class Hero
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }

    public Hero(string name, int health, int attack, int defense)
    {
        Name = name;
        Health = health;
        Attack = attack;
        Defense = defense;
    }

    public abstract void DisplayStats();
}