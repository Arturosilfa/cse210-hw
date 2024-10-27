namespace EternalQuest
{
    class SimpleGoal : Goal
    {
        public SimpleGoal(string name, int points) : base(name, points) { }

        public override void RecordProgress()
        {
            if (!IsComplete)
            {
                IsComplete = true;
                Console.WriteLine($"Goal '{Name}' completed! You earned {Points} points.");
            }
            else
            {
                Console.WriteLine($"Goal '{Name}' has already been completed.");
            }
        }

        public override string GetStatus()
        {
            return IsComplete ? "[X] " + Name : "[ ] " + Name;
        }

        public override string Serialize()
        {
            return $"SimpleGoal|{Name}|{Points}|{IsComplete}";
        }
    }
}
