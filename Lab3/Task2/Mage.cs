namespace FileLoggerApp
{
    public class Mage : Hero
    {
        public Mage(string name)
        {
            Name = name;
        }

        public override string Description()
        {
            return $"{Name} - Mage, a master of magic.";
        }
    }
}
