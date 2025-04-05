namespace FileLoggerApp
{
    public class Warrior : Hero
    {
        public Warrior(string name)
        {
            Name = name;
        }

        public override string Description()
        {
            return $"{Name} - Warrior, a brave fighter.";
        }
    }
}
