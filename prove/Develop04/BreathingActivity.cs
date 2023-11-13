//namespace Develop04;
using System;
using System.Threading;
using System.Diagnostics;
/// <summary>
/// Breathing activity
/// </summary>
public class Breath: program
{
  private const int BREATH_IN_DURATION = 3;
  private const int BREATH_OUT_DURATION = 3;

  /// <summary>
  /// Initializes Activity with name and description
  /// </summary>
  public Breath()
  : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
  {
  }

  /// <summary>
  /// Runs the activity
  /// </summary>
  public void Run()
  {
    DisplayStartingMessage();

    int breathCount = GetBreathCount();

    for (int i = 0; i < breathCount; i++)
    {
      ShowBreathInMessage(BREATH_IN_DURATION);
      ShowBreathOutMessage(BREATH_OUT_DURATION);
    }

    DisplayEndingMessage();
  }

  // Calculates the number of times to breath in/out
  private int GetBreathCount()
  {
    int total = durationInSeconds;
    return (total / (BREATH_IN_DURATION + BREATH_OUT_DURATION)) + 1;
  }

  /// <summary>
  /// Displays the breathing in message
  /// </summary>
  private void ShowBreathInMessage(int duration)
  {
    Console.Write("Breath in ...");
    ShowCountDownTimer(duration);
  }

  /// <summary>
  /// Displays the breathing out message
  /// </summary>
  private void ShowBreathOutMessage(int duration)
  {
    Console.Write("Breath out ...");
    ShowCountDownTimer(duration);
  }
}


























































































































































































































































































































































/*using System;
using System.Threading;
using System.Diagnostics;
            public class Breath
{

    private List<string> start = new List<string> { "|", "/", "—", "\\", "|", "/", "—", "\\" };
    private void Welcome()
    {
       // The standard starting message 
        Console.WriteLine("Welcome to the Breathing Activity!");
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
       string input = Console.ReadLine();
       int seconds = int.Parse(input);
        Console.WriteLine("Get ready...");
        foreach (string s in start)
        {
           Console.WriteLine(s);
           Thread.Sleep(1000);
          Console.WriteLine("\b \b");
       }
        Console.WriteLine("");
        int c = 3;
        while (c > 0)
      {
           double k = Math.Ceiling(seconds * 0.13);
           Console.WriteLine("Breathe in ...");
           while (k > 0)
           {                Console.WriteLine(k);
                 Thread.Sleep(1000);
              
             Console.WriteLine("\b\b");             
              k--;
           }
      }
    }
}        */                                                                           
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 