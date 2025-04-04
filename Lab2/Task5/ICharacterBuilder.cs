public interface ICharacterBuilder
{
    ICharacterBuilder SetName(string name);
    ICharacterBuilder SetHeight(string height);
    ICharacterBuilder SetBuild(string build);
    ICharacterBuilder SetHairColor(string color);
    ICharacterBuilder SetEyeColor(string color);
    ICharacterBuilder SetOutfit(string outfit);
    ICharacterBuilder AddToInventory(string item);
    ICharacterBuilder AddGoodDeed(string deed);  // Цей метод для героя
    ICharacterBuilder AddEvilDeed(string deed);  // Цей метод для ворога
    object Build();
}
