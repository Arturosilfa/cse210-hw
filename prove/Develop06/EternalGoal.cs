namespace EternalQuest
{
    class EternalGoal : Goal
    {
        public EternalGoal(string name, int points) : base(name, points) { }

        public override void RecordProgress()
        {
            Console.WriteLine($"Recorded progress for '{Name}'. You earned {Points} points.");
        }

        public override string GetStatus()
        {
            return "[∞] " + Name;
        }

        public override string Serialize()
        {
            return $"EternalGoal|{Name}|{Points}";
        }
    }
}
