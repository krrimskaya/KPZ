namespace FileLoggerApp
{
    public abstract class InventoryDecorator : Hero
    {
        protected Hero _hero;

        public InventoryDecorator(Hero hero)
        {
            _hero = hero;
        }

        public override string Description()
        {
            return _hero.Description();
        }
    }
}
