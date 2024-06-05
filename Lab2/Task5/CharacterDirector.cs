public class CharacterDirector
{
    public Character BuildHero(CharacterBuilder builder)
    {
        return builder
            .SetHeight(170)
            .SetBuild("Athletic")
            .SetHairColor("Black")
            .SetEyeColor("Brown")
            .SetClothing("Armor")
            .AddInventoryItem("Sword")
            .AddGoodDeed("Saved a village")
            .Build();
    }

    public Character BuildEnemy(CharacterBuilder builder)
    {
        return builder
            .SetHeight(180)
            .SetBuild("Muscular")
            .SetHairColor("Black")
            .SetEyeColor("Green")
            .SetClothing("Robe")
            .AddInventoryItem("Staff")
            .AddEvilDeed("Destroyed a village")
            .Build();
    }
}