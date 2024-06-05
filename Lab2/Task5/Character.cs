using System.Collections.Generic;

public class Character
{
    public double Height { get; set; }
    public string Build { get; set; }
    public string HairColor { get; set; }
    public string EyeColor { get; set; }
    public string Clothing { get; set; }
    public List<string> Inventory { get; set; } = new List<string>();
    public List<string> GoodDeeds { get; set; } = new List<string>();
    public List<string> EvilDeeds { get; set; } = new List<string>();

    public override string ToString()
    {
        return $"Height: {Height}, Build: {Build}, Hair Color: {HairColor}, Eye Color: {EyeColor}, Clothing: {Clothing}, " +
               $"Inventory: {string.Join(", ", Inventory)}, Good Deeds: {string.Join(", ", GoodDeeds)}, Evil Deeds: {string.Join(", ", EvilDeeds)}";
    }
}