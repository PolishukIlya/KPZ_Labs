public interface CharacterBuilder
{
    CharacterBuilder SetHeight(double height);
    CharacterBuilder SetBuild(string build);
    CharacterBuilder SetHairColor(string hairColor);
    CharacterBuilder SetEyeColor(string eyeColor);
    CharacterBuilder SetClothing(string clothing);
    CharacterBuilder AddInventoryItem(string item);
    CharacterBuilder AddGoodDeed(string deed);
    CharacterBuilder AddEvilDeed(string deed);
    Character Build();
}