using System.Numerics;
using System;
using System.Collections.Generic;
using System.IO;
//namespace Develop04;

class ReflectionActivity : Activity
{
    private string[] _prompts = new string[] {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };


    private string[] _questions = new string[] {
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
        
    public ReflectionActivity()
    {
        _activityName = "Reflection Activity";
        _activityDescription ="This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public override void Start()
    {
        // Start activity
        base.Start();

        Random random = new Random();
        int promptIndex = random.Next(_prompts.Length);
        string prompt = _prompts[promptIndex];
            // Perform activity
            Console.WriteLine("Consider de following prompt \n");
            Console.WriteLine($"\t--- {prompt} ---");
            Console.WriteLine();
            Console.WriteLine("When you have something in mind press enter to continue.");
            Console.ReadKey();

            Console.WriteLine("Reflect about the following questions.");
            Console.Write("You may begin in: ");
            Animation(ANIMATION_COUNTDOWN,3);
            Console.Clear();

            DateTime currentTime = DateTime.Now;
            DateTime futureTime = DateTime.Now.AddSeconds(_duration);

            do{
                int questionIndex = random.Next(_questions.Length);
                string question = _questions[questionIndex];

                Console.Write($"> {question} ");
                Animation(ANIMATION_SPINNER, 5);
                Console.WriteLine();

                currentTime = DateTime.Now;
            }while(currentTime < futureTime);
        
        base.End();
    }
}

































































































































































































































































































































































































/*/// <Summary>
/// Reflecting activity
/// </Summary>
public class Reflection : Activity
{
  private Random random = new Random();

  private const int PONDER_DURATION = 5;

  private List<string> PROMPTS = new List<string>
  {
    "Think of a time when you stood up for someone else",
    "Think of a time when you did something really difficult",
    "Think of a time when you helped someone in need",
    "Think of a time when you did something truly selfless",
  };

  private List<string> QUESTIONS = new List<string>
  {
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?",
  };

  /// <Summary>
  /// Initializes Activity with the name and description
  /// </Summary>
  public Reflection()
  : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
  {
  }

  /// <Summary>
  /// Runs the activity
  /// </Summary>
  public void Run()
  {
    DisplayStartingMessage();
    Console.WriteLine();
    Console.WriteLine(GetRandomPrompt());
    Console.Write("When you have something in mind, press enter to continue.");
    Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
    Console.Write("You will being in:");
    ShowCountDownTimer(3);
    Console.WriteLine();

    List<string> questions = GetQuestions();
    questions.ForEach(question =>
    {
      Console.Write(question);
      ShowSpinner(PONDER_DURATION);
    });

    DisplayEndingMessage();
  }

  /// <Summary>
  /// Gets a list of questions that can be listed within the time the user wants to be presented questions
  /// </Summary>
  private List<string> GetQuestions()
  {
    int questionCount = (durationInSeconds / PONDER_DURATION) + 1;
    List<string> unusedQuestions = QUESTIONS.Select(q => q).ToList();
    List<string> usedQuestions = new List<string>();
    for (int i = 0; i < questionCount; i++)
    {
      string question = unusedQuestions[random.Next(unusedQuestions.Count)];
      unusedQuestions.Remove(question);
      usedQuestions.Add(question);
    }

    return usedQuestions;
  }

  /// <Summary>
  /// Returns a random prompt
  /// </Summary>
  private string GetRandomPrompt()
  {
    return PROMPTS[random.Next(PROMPTS.Count)];
  }

  /// <Summary>
  /// Returns a random question
  /// </Summary>
  private string GetRandomQuestion()
  {
    return QUESTIONS[random.Next(QUESTIONS.Count)];
  }
}



















































































































































































































































































































































































/*using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


/*public class Reflection
{
    private List<string> start = new List<string> { "|", "/", "—", "\\", "|", "/", "—", "\\" };
    private List<string> prompts = new List<string> { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };
    private List<string> questions = new List<string> { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?" };
     private Random random;
    public Reflection()
    {
        Console.WriteLine("How long, in seconds, would you like for your session? ");
         string input = Console.ReadLine();
         int seconds = int.Parse(input);
         Console.WriteLine("Get ready...");
        foreach (string s in start)
        {
             Console.WriteLine(s);
             Thread.Sleep(1000);
            Console.Write("\b \b");
           //prompts = new List<prompt>();
           //random = new Random();
         }
     }
     private void NotSureWhyThisCodeIsInTheClassBody()
    {
        Console.WriteLine(" ");
         Console.WriteLine("Consider the following prompt:");
        Random random = new Random();
        int activity = prompts.Count();
        Console.WriteLine($"--- {prompts[random.Next(activity)]} ---");
         Console.WriteLine(" ");
         Console.WriteLine("Press enter to continue.");
         var userInput = Console.ReadKey();
        if (userInput.Key == ConsoleKey.Enter)
        {
             Console.WriteLine(" ");
             Console.WriteLine(" Reflect on each of the following questions, related to this experience.");
             int k = 5;
             Console.WriteLine("You may begin in:");
            while (k > 0)
            {
                 Console.WriteLine(k);
                 Thread.Sleep(1000);
                Console.WriteLine("\b \b");
                 k--;
             }
             Console.WriteLine(" ");

             random = new Random();
             int activity1 = questions.Count();
             Console.WriteLine($"> {questions[random.Next(activity1)]} ");
            int seconds = 3000; // Three seconds. 
            foreach (string s in start)
            {
                 Console.Write(s);
                Thread.Sleep(seconds * 50);
                Console.Write("\b \b");
             }
             Console.WriteLine(" ");
             Console.WriteLine("Well done!");
             Console.WriteLine($"You have completed another {seconds} seconds of Reflecting Activity.");
            foreach (string s in start)
            {
                 Console.Write(s);
                 Thread.Sleep(1000);
                Console.Write("\b \b");
             }
 
        }
     }

}*/




