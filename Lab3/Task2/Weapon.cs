namespace FileLoggerApp
{
    public class Weapon : InventoryDecorator
    {
        public Weapon(Hero hero) : base(hero) { }

        public override string Description()
        {
            return base.Description() + " Wielding a Sword.";
        }
    }
}
