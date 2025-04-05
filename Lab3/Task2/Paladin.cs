namespace FileLoggerApp
{
    public class Paladin : Hero
    {
        public Paladin(string name)
        {
            Name = name;
        }

        public override string Description()
        {
            return $"{Name} - Paladin, a holy warrior.";
        }
    }
}
