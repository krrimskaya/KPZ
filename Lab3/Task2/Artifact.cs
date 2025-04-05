namespace FileLoggerApp
{
    public class Artifact : InventoryDecorator
    {
        public Artifact(Hero hero) : base(hero) { }

        public override string Description()
        {
            return base.Description() + " Holding a Magical Artifact.";
        }
    }
}
