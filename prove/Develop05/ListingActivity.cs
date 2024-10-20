class ListingActivity : MindfulnessActivity
{
    private string[] prompts = {
        "List people you appreciate.",
        "List your personal strengths.",
        "List people you've helped recently."
    };

    private Random random = new Random();

    public void Run()
    {
        StartActivity("Listing", "This activity will help you reflect on positive aspects of your life.");
        
        Console.WriteLine(prompts[random.Next(prompts.Length)]);  // Random prompt
        ShowAnimation(5);  // Pause for 5 seconds to allow thinking time
        
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        int itemCount = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item: ");
            string item = Console.ReadLine();
            itemCount++;
        }

        Console.WriteLine($"You listed {itemCount} items.");
        EndActivity("Listing");
    }
}
