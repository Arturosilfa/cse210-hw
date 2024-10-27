using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    class EternalQuest
    {
        private List<Goal> goals;
        private int totalScore;

        public EternalQuest()
        {
            goals = new List<Goal>();
            totalScore = 0;
        }

        public void AddGoal(Goal goal)
        {
            goals.Add(goal);
        }

        public void RecordGoalProgress(string goalName)
        {
            var goal = goals.Find(g => g.Name.Equals(goalName, StringComparison.OrdinalIgnoreCase));
            if (goal != null)
            {
                goal.RecordProgress();
                if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete)
                    totalScore += checklistGoal.BonusPoints;
                totalScore += goal.Points;
            }
            else
            {
                Console.WriteLine("Goal not found.");
            }
        }

        public void DisplayGoals()
        {
            Console.WriteLine("Your Goals:");
            foreach (var goal in goals)
            {
                Console.WriteLine(goal.GetStatus());
            }
        }

        public void DisplayScore()
        {
            Console.WriteLine($"Total Score: {totalScore}");
        }

        public void SaveGoals(string fileName)
        {
            using (StreamWriter file = new StreamWriter(fileName))
            {
                foreach (var goal in goals)
                {
                    file.WriteLine(goal.Serialize());
                }
            }
            Console.WriteLine("Goals saved.");
        }

        public void LoadGoals(string fileName)
        {
            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                goals.Clear();
                foreach (var line in lines)
                {
                    Goal goal = Goal.Deserialize(line);
                    if (goal != null)
                        goals.Add(goal);
                }
                Console.WriteLine("Goals loaded.");
            }
            else
            {
                Console.WriteLine("No saved goals found.");
            }
        }
    }
}
