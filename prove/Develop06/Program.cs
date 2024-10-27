using System;

namespace EternalQuest
{
    class Program
    {
        static void Main()
        {
            EternalQuest quest = new EternalQuest();

            while (true)
            {
                Console.WriteLine("\nEternal Quest Menu:");
                Console.WriteLine("1. Add Simple Goal");
                Console.WriteLine("2. Add Eternal Goal");
                Console.WriteLine("3. Add Checklist Goal");
                Console.WriteLine("4. Record Progress");
                Console.WriteLine("5. Display Goals");
                Console.WriteLine("6. Display Score");
                Console.WriteLine("7. Save Goals");
                Console.WriteLine("8. Load Goals");
                Console.WriteLine("9. Exit");
                Console.Write("Choose an option: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input, please enter a number between 1 and 9.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter goal name: ");
                        string simpleGoalName = Console.ReadLine();
                        Console.Write("Enter points: ");
                        int simplePoints = int.Parse(Console.ReadLine());
                        quest.AddGoal(new SimpleGoal(simpleGoalName, simplePoints));
                        break;
                    case 2:
                        Console.Write("Enter goal name: ");
                        string eternalGoalName = Console.ReadLine();
                        Console.Write("Enter points: ");
                        int eternalPoints = int.Parse(Console.ReadLine());
                        quest.AddGoal(new EternalGoal(eternalGoalName, eternalPoints));
                        break;
                    case 3:
                        Console.Write("Enter goal name: ");
                        string checklistGoalName = Console.ReadLine();
                        Console.Write("Enter points: ");
                        int checklistPoints = int.Parse(Console.ReadLine());
                        Console.Write("Enter times required to complete: ");
                        int timesRequired = int.Parse(Console.ReadLine());
                        Console.Write("Enter bonus points: ");
                        int bonusPoints = int.Parse(Console.ReadLine());
                        quest.AddGoal(new ChecklistGoal(checklistGoalName, checklistPoints, timesRequired, bonusPoints));
                        break;
                    case 4:
                        Console.Write("Enter goal name to record progress: ");
                        string goalName = Console.ReadLine();
                        quest.RecordGoalProgress(goalName);
                        break;
                    case 5:
                        quest.DisplayGoals();
                        break;
                    case 6:
                        quest.DisplayScore();
                        break;
                    case 7:
                        quest.SaveGoals("goals.txt");
                        break;
                    case 8:
                        quest.LoadGoals("goals.txt");
                        break;
                    case 9:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please choose a number between 1 and 9.");
                        break;
                }
            }
        }
    }
}
