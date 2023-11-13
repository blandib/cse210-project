//namespace Develop04;
using System;
using System.ComponentModel;
using System.Globalization;

using System;

/***********************************************************************************************
 - Showing Creativity and Exceeding Requirements
 1) I add Remimber Activity (option 4)

************************************************************************************************/
class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        int choice = -1;
        do
        {   
            ShowMenu();
            Console.Write("Please Type The Number Corresponding With Your Choice: ");
            choice = int.Parse(Console.ReadLine());


            Activity activity;
            switch(choice) 
            {
                case 1:
                    activity = new BreathingActivity();
                    activity.Start();
                    break;
                case 2:
                    activity = new ReflectionActivity();
                    activity.Start();
                    break;
                case 3:
                    activity = new ListingActivity();
                    activity.Start();
                    break;
                case 4:
                    activity = new ReminderActivity();
                    activity.Start();
                    break;
                case 0:
                    // display good bye message
                    DisplayEndMessage();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please Select a correct value");
                    break;
            }

        }while (choice != 0);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Mindfulness program!");
    }

    static void DisplayEndMessage()
    {
        Console.Clear();
        Console.WriteLine("Good Bye");
    }

    static void ShowMenu(){
        Console.Clear();
        Console.Write("""
            Would you like to:

            1) Start Breathing Activity
            2) Start Reflection Activity
            3) Start Listing Activity
            4) Start Remimder Activity
            0) Exit

            """);
    }

}





































































































































































/*/// <summary>
/// Base class for all Activities
/// </summary>
public abstract class program
{
  static void Main(string[] args) 
   
  private string name;
  private string description;

  // Declared protected so that it can be accessed by subclasses
  protected int durationInSeconds;
  protected string description;
  protected string name;

  /// <summary>
  /// Initializes the name and description of the activity
  /// </summary>
  /// <param name="name">Menu Options: , 1. Start breathing activity, 2. Start reflecting activity, 3. Start listing activity, 4. Quit", "Select a choice from the menu:</param>
  /// <param name="description"> This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing., This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.</param>
  public Program(string name, string description)
  {
    this.name = name;
    this.description = description;
  }

  /// <summary>
  /// Display the welcome prompt and get the duration of the activity from the user
  /// </summary>
  /// <param name="DisplayWelcome">Welcome to the Breathing Activity;</param>
 /// <param name="Duration">How long, in seconds, would you like for your session</param>
  protected void DisplayStartingMessage()
  {
    Console.Clear();
    Console.WriteLine($"Welcome to the {name} Activity.");
    Console.WriteLine();
    Console.WriteLine(description);
    Console.WriteLine();
    durationInSeconds = PromptForValidInt("How long, in seconds, would you like for your session? ");
    Console.Clear();
    Console.Write("Get ready ...");
    ShowCountDownTimer(3);
  }

  /// <summary>
  /// Display the end message
  /// </summary>
 ///<param name="EndMessage"> Well done!!</param>
  protected void DisplayEndingMessage()
  {
    Console.WriteLine();
    Console.Write("Well done!!");
    Console.WriteLine();
    Console.WriteLine();
    Console.Write($"You have completed another {durationInSeconds} seconds of the {name} Activity.");
    ShowSpinner(3);
  }

  /// <summary>
  /// Clears the console of characters indicated by charCount
  /// </summary>
  ///<param name="CharCount"></param>
  private void ClearCharacters(int charCount)
  {
    string backspaces = new string('\b', charCount);
    string spaces = new string(' ', charCount);
    Console.Write($"{backspaces}{spaces}{backspaces}");
  }

  /// <summary>
  /// Show the count down timer for time indicated by seconds
  /// </summary>
  /// <param name="seconds"></param>
  protected void ShowCountDownTimer(int seconds)
  {
    Console.Write($" {seconds}");
    while (seconds > 0)
    {
      Thread.Sleep(1000);
      ClearCharacters(seconds.ToString().Length);
      Console.Write($"{--seconds}");
    }

    ClearCharacters(1);
    Console.WriteLine();
  }

  /// <summary>
  /// Show the spinner for the time indicated by seconds
  /// </summary>
  protected void ShowSpinner(int seconds)
  {
    char[] spinnerChars = { '-', '\\', '|', '/', };
    DateTime endTime = DateTime.Now.AddSeconds(seconds);
    int index = 0;

    Console.Write($" {spinnerChars[index]}");

    while (DateTime.Now < endTime)
    {
      index = index + 1 < spinnerChars.Length ? index + 1 : 0;
      Thread.Sleep(100);
      Console.Write($"\b{spinnerChars[index]}");
    }

    ClearCharacters(1);
    Console.WriteLine();
  }

  /// <summary>
  /// Prompts user and validates that user enters an int. Returns the int value.
  /// </summary>
  private int PromptForValidInt(string question)
  {
    int input = 0;

    while (true)
    {
      try
      {
        Console.Write(question);
        input = Convert.ToInt32(Console.ReadLine());
        break;
      }
      catch
      {
        Console.WriteLine();
        Console.WriteLine("Invalid Input. Must be integer.");
      }
    }

    return input;
  }
}*/














































































































































































































































































































































































































/*using System;
using System.ComponentModel;
using System.Globalization;

class  Program
 {
     static void Main(string[] args)
     {

        List<string> menu = new List<string> { "Menu Options: ", "1. Start breathing activity", "2. Start reflecting activity", "3. Start listing activity", "4. Quit", "Select a choice from the menu:" };
         bool repeat = true;
        while (repeat == true)
        {
             for (int i = 0; i < menu.Count(); i++)
             {
                 Console.WriteLine(menu[i]);

             }
             string userChoice = Console.ReadLine();
             int activity = int.Parse(userChoice);

            if (activity == 1)
            {
                Breath breathe = new Breath();
                // Method BreathingActivity() doesn't exist
                // breathe.BreathingActivity(); 
             }
            else if (activity == 2)
            {
                Refletion reflection = new Refletion();
                // Method ReflectActivity() doesn't exist
                // reflect.ReflectActivity();
             }

            else if (activity == 3)
            {
                Listing list = new Listing();
                 list.ListActivity();
             }

            else if (activity == 4)
            {
                 repeat = false;
             }
           
            else if (activity < 1 || activity > 4)
            {
                 repeat = false;
            }

        }
    }
     }*/
 
 



















































