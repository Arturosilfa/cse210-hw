class MindfulnessActivity
{
    protected int duration;  // Duration in seconds

    public void StartActivity(string activityName, string description)
    {
        Console.WriteLine($"Starting {activityName}...");
        Console.WriteLine(description);
        Console.Write("Enter duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowAnimation(3);  // Pause for 3 seconds
    }

    public void EndActivity(string activityName)
    {
        Console.WriteLine($"Good job! You've completed the {activityName} activity for {duration} seconds.");
        ShowAnimation(3);  // Pause for 3 seconds
    }

    protected void ShowAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
