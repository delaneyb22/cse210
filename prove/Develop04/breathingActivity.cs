using System;

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    public override void Start()
    {
        SetDuration();
        Console.WriteLine("Prepare to begin...");
        Console.WriteLine("Start breathing in...");

        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine("Breathe in...");
            Console.WriteLine("Breathe out...");
        }
    }

    public override void End()
    {
        Console.WriteLine("You have done a good job");
        Console.WriteLine("You have completed Breathing activity for " + duration + " seconds");
    }
}
