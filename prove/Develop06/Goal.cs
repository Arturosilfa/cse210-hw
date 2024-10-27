using System;

namespace EternalQuest
{
    abstract class Goal
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public bool IsComplete { get; protected set; }

        public Goal(string name, int points)
        {
            Name = name;
            Points = points;
            IsComplete = false;
        }

        public abstract void RecordProgress();

        public abstract string GetStatus();

        public abstract string Serialize();

        public static Goal Deserialize(string line)
        {
            string[] parts = line.Split('|');
            try
            {
                switch (parts[0])
                {
                    case "SimpleGoal":
                        return new SimpleGoal(parts[1], int.Parse(parts[2]));
                    case "EternalGoal":
                        return new EternalGoal(parts[1], int.Parse(parts[2]));
                    case "ChecklistGoal":
                        return new ChecklistGoal(parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]));
                    default:
                        throw new Exception("Unknown goal type.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deserializing goal: {ex.Message}");
                return null;
            }
        }
    }
}
