namespace FileLoggerApp
{
    public class Armor : InventoryDecorator
    {
        public Armor(Hero hero) : base(hero) { }

        public override string Description()
        {
            return base.Description() + " Equipped with Armor.";
        }
    }
}
