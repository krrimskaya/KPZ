public class HeroBuilder : ICharacterBuilder
{
    private Hero _hero;

    public HeroBuilder()
    {
        _hero = new Hero();
    }

    public ICharacterBuilder SetName(string name)
    {
        _hero.Name = name;
        return this;
    }

    public ICharacterBuilder SetHeight(string height)
    {
        _hero.Height = height;
        return this;
    }

    public ICharacterBuilder SetBuild(string build)
    {
        _hero.Build = build;
        return this;
    }

    public ICharacterBuilder SetHairColor(string color)
    {
        _hero.HairColor = color;
        return this;
    }

    public ICharacterBuilder SetEyeColor(string color)
    {
        _hero.EyeColor = color;
        return this;
    }

    public ICharacterBuilder SetOutfit(string outfit)
    {
        _hero.Outfit = outfit;
        return this;
    }

    public ICharacterBuilder AddToInventory(string item)
    {
        _hero.Inventory.Add(item);
        return this;
    }

    public ICharacterBuilder AddGoodDeed(string deed)
    {
        _hero.GoodDeeds.Add(deed);
        return this;
    }

    public ICharacterBuilder AddEvilDeed(string deed)
    {
        return this;
    }

    public object Build()
    {
        return _hero;
    }
}
