public class EnemyBuilder : ICharacterBuilder
{
    private Enemy _enemy;

    public EnemyBuilder()
    {
        _enemy = new Enemy();
    }

    public ICharacterBuilder SetName(string name)
    {
        _enemy.Name = name;
        return this;
    }

    public ICharacterBuilder SetHeight(string height)
    {
        _enemy.Height = height;
        return this;
    }

    public ICharacterBuilder SetBuild(string build)
    {
        _enemy.Build = build;
        return this;
    }

    public ICharacterBuilder SetHairColor(string color)
    {
        _enemy.HairColor = color;
        return this;
    }

    public ICharacterBuilder SetEyeColor(string color)
    {
        _enemy.EyeColor = color;
        return this;
    }

    public ICharacterBuilder SetOutfit(string outfit)
    {
        _enemy.Outfit = outfit;
        return this;
    }

    public ICharacterBuilder AddToInventory(string item)
    {
        _enemy.Inventory.Add(item);
        return this;
    }

    public ICharacterBuilder AddGoodDeed(string deed)
    {
        return this; // Для ворога цей метод може бути порожнім
    }

    public ICharacterBuilder AddEvilDeed(string deed)
    {
        _enemy.EvilDeeds.Add(deed);
        return this;
    }

    public object Build()
    {
        return _enemy;
    }
}
