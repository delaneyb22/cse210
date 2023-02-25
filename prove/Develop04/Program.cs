using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program. Pick an activity to begin. Type 4 to stop");
        int menuOption;
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Listing Activity");
        Console.WriteLine("3. Reflection Activity");
        menuOption= int.Parse(Console.ReadLine());
       do{
        if (menuOption == 1){
            Activity b = new breathingActivity();
            b.Start();
        }else if(menuOption==2){
            Activity l = new ListingActivity();
            l.Start();
        }else if(menuOption==3){
            Activity r = new ReflectionActivity();
            r.Start();
        }
       }while(menuOption!=4);
    }
}
// Base class for activities
abstract class Activity
{
    protected int duration;
    protected string _name;
    protected string _description;

    public Activity(string name, string description)
    {
        this._name = name;
        this._description = description;
    }

    public abstract void Start();
    public abstract void End();

    protected void SetDuration()
    {
        Console.WriteLine("Enter the duration in seconds: ");
       // int _duration = int.Parse(Console.ReadLine());
        duration = Convert.ToInt32(Console.ReadLine());
    }
}

// Breathing activity class
class breathingActivity : Activity
{
    public breathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

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
        Console.WriteLine("Great job!");
        Console.WriteLine("You have completed the breathing activity for " + duration + " seconds");
    }
}

// Reflection activity class
class ReflectionActivity : Activity
{
    protected List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") { }

    

    public override void Start()
    {
        SetDuration();
        Console.WriteLine("Prepare to begin...");
        Console.WriteLine(prompts[new Random().Next(prompts.Count)]);

        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine(questions[new Random().Next(questions.Count)]);
        }
    }

    public override void End()
    {
        Console.WriteLine("You have done a good job");
        Console.WriteLine ("Press any key to exit");
        Console.ReadKey();
    }
}
//listing activity class
class ListingActivity : Activity{
    protected List<string> listPrompts = new List<string>{
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };




    public override void Start()
    {
        SetDuration();
        Console.WriteLine("Prepare to begin...");

        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine(listPrompts[new Random().Next(listPrompts.Count)]);
        }
        
    }
      public override void End()
    {
        Console.WriteLine("You have done a good job");
        Console.WriteLine ("Press any key to exit");
        Console.ReadKey();
    }
    public ListingActivity() : base("Listing", "This activity will help you reflect on moments in your day where you are being blessed that often get passed up.") { }
}
