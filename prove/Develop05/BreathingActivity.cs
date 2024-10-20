class BreathingActivity : MindfulnessActivity
{
    public void Run()
    {
        StartActivity("Breathing", "This activity will help you relax by guiding you through deep breathing.");
        
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowAnimation(3);  // 3 seconds to breathe in
            Console.WriteLine("Breathe out...");
            ShowAnimation(3);  // 3 seconds to breathe out
        }

        EndActivity("Breathing");
    }
}
