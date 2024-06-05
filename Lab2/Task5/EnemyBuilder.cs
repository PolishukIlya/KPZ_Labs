public class EnemyBuilder : CharacterBuilder
{
    private Character _character = new Character();

    public CharacterBuilder SetHeight(double height)
    {
        _character.Height = height;
        return this;
    }

    public CharacterBuilder SetBuild(string build)
    {
        _character.Build = build;
        return this;
    }

    public CharacterBuilder SetHairColor(string hairColor)
    {
        _character.HairColor = hairColor;
        return this;
    }

    public CharacterBuilder SetEyeColor(string eyeColor)
    {
        _character.EyeColor = eyeColor;
        return this;
    }

    public CharacterBuilder SetClothing(string clothing)
    {
        _character.Clothing = clothing;
        return this;
    }

    public CharacterBuilder AddInventoryItem(string item)
    {
        _character.Inventory.Add(item);
        return this;
    }

    public CharacterBuilder AddGoodDeed(string deed)
    {
        return this;
    }

    public CharacterBuilder AddEvilDeed(string deed)
    {
        _character.EvilDeeds.Add(deed);
        return this;
    }

    public Character Build()
    {
        return _character;
    }
}