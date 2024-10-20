class ReflectionActivity : MindfulnessActivity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really hard.",
        "Think of a time when you helped someone in need."
    };

    private string[] questions = {
        "Why was this experience meaningful?",
        "What did you learn about yourself from this experience?"
    };

    private Random random = new Random();

    public void Run()
    {
        StartActivity("Reflection", "This activity will help you reflect on moments of strength and resilience.");
        
        Console.WriteLine(prompts[random.Next(prompts.Length)]);  // Random prompt
        
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine(questions[random.Next(questions.Length)]);  // Random question
            ShowAnimation(5);  // Pause for 5 seconds after each question
        }

        EndActivity("Reflection");
    }
}
