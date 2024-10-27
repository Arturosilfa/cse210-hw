namespace EternalQuest
{
    class ChecklistGoal : Goal
    {
        public int TimesRequired { get; private set; }
        public int TimesCompleted { get; private set; }
        public int BonusPoints { get; private set; }

        public ChecklistGoal(string name, int points, int timesRequired, int bonusPoints)
            : base(name, points)
        {
            TimesRequired = timesRequired;
            BonusPoints = bonusPoints;
            TimesCompleted = 0;
        }

        public override void RecordProgress()
        {
            if (!IsComplete)
            {
                TimesCompleted++;
                Console.WriteLine($"Progress recorded for '{Name}'. You earned {Points} points.");
                if (TimesCompleted >= TimesRequired)
                {
                    IsComplete = true;
                    Console.WriteLine($"Goal '{Name}' completed! Bonus of {BonusPoints} points awarded.");
                }
            }
            else
            {
                Console.WriteLine($"Goal '{Name}' has already been completed.");
            }
        }

        public override string GetStatus()
        {
            return IsComplete ? $"[X] {Name} (Completed {TimesCompleted}/{TimesRequired})"
                              : $"[ ] {Name} (Completed {TimesCompleted}/{TimesRequired})";
        }

        public override string Serialize()
        {
            return $"ChecklistGoal|{Name}|{Points}|{TimesRequired}|{BonusPoints}|{TimesCompleted}";
        }
    }
}
