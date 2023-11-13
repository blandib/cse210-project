//namespace Develop04;
using System;
using System.Collections.Generic;
using System.IO;
class ListingActivity : Activity
{
    private string[] _prompts = new string[] {
        "Who are people that you appreciate?.",
        "What are personal strengths of yours?.",
        "Who are people that you have helped this week?.",
        "When have you felt the Holy Ghost this month?.",
        "Who are some of your personal heroes?."
    };
    public ListingActivity()
    {
        _activityName = "Listing Activity";
        _activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public override void Start()
    {
        // Start activity
        base.Start();
        // Get prompt
            Random random = new Random();

            int index = random.Next(_prompts.Length);
            string prompt = _prompts[index];

            List<string> answers = new List<string>();

            Console.WriteLine("list as many responses you can to the following prompt");
            Console.WriteLine($"\t---{prompt}---");
            Console.Write("You may begin in: ");
            Animation(ANIMATION_COUNTDOWN,3);
            Console.WriteLine();

            DateTime currentTime = DateTime.Now;
            DateTime futureTime = DateTime.Now.AddSeconds(_duration);
            do{
                Console.Write("> ");
                answers.Add(Console.ReadLine());
                Console.WriteLine();
                currentTime = DateTime.Now;
            }while(currentTime < futureTime);

            Console.WriteLine($"You listed {answers.Count()} items!");



        
        base.End();
    }
}










































































































































































































































/*/// <summary>
/// List Activity
/// </summary>
public class Listing : Activity
{
  private Random random = new Random();

  private List<string> PROMPTS = new List<string>(){
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?",
  };

  /// <summary>
  /// Initializes Activity with the name and description
  /// </summary>
  public Listing()
    : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
  {
  }

  /// <summary>
  /// Runs the activity
  /// </summary>
  /*public void Run()
  {
    DisplayStartingMessage();
    Console.WriteLine();
    Console.WriteLine("List as many responses you can to the following prompt:");
    Console.WriteLine(GetRandomPrompt());
    Console.Write("You may begin in:");
    ShowCountDownTimer(3);

    DateTime endTime = DateTime.Now.AddSeconds(durationInSeconds);
    int remainingTime = (endTime - DateTime.Now).Seconds;
    while (remainingTime > 0)
    {
      Console.Write($"[{remainingTime}s left]> ");
      Console.ReadLine();
      remainingTime = (endTime - DateTime.Now).Seconds;
    }

    DisplayEndingMessage();
  }

  /// <summary>
  /// Returns a random prompt
  /// </summary>
  private string GetRandomPrompt()
  {
    return PROMPTS[random.Next(PROMPTS.Count)];
  }
}*/



















































































































































































































































































































































/*using System;
using System.Collections.Generic;
using System.IO;
//namespace Develop04;

public class Listing
{
    private List<string> start = new List<string> { "|", "/", "—", "\\", "|", "/", "—", "\\" };
    private List<string> prompts1 = new List<string> { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };
   private List<string> items = new List<string>();
     private Random random;

    public void ListActivity()
    {
         Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
         Console.WriteLine("How long, in seconds, would you like for your session? ");
         string input = Console.ReadLine();
         int seconds = int.Parse(input);
         Console.Write("Get ready...");
        foreach (string s in start)
        {
             Console.Write(s);
             Thread.Sleep(1000);

            Console.Write("\b \b");
         }

        Console.WriteLine(" ");
         Console.WriteLine("Consider the following prompt:");
         Random random = new Random();
         int activity2 = prompts1.Count();
         Console.WriteLine($"--- {prompts1[random.Next(activity2)]} ---");
         int k = 5;
        Console.WriteLine("You may begin in:");
        while (k > 0)
        {
            Console.WriteLine(k);
            Thread.Sleep(1000);
            Console.WriteLine("\b \b");
            k--;
 
        }
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("> ");
            string item = Console.ReadLine();
            items.Add(item);
        }
        Console.WriteLine(" ");
        Console.WriteLine($"You listed {items.Count()} items");
        Console.WriteLine(" ");
        Console.WriteLine("Well done!");
        foreach (string s in start)
        {
            Console.WriteLine(s);
            Thread.Sleep(1000);
            Console.WriteLine("\b \b");
        }
     }
}*/



  