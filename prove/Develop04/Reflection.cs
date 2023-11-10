using System;
using System.Collections.Generic;
using System.IO;


public class Reflection
    {
    private list <string> start =  new List<string> {"|", "/", "—", "\\", "|", "/", "—", "\\"};
    private List<prompt> prompts =  new List<string> {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
     private List <string> questions = new List<string> {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
    private Random random;
    public  void Reflection() {
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        string input = Console.ReadLine();
        int seconds = int.Parse(input);
        Console.WriteLine("Get ready...");
        foreach (string s in start) {
            Console.WriteLine(s);
            Thread.Sleep(1000);
            Console.Write("\R \R");
      //prompts = new List<prompt>();
      //random = new Random();
        }
    }
     Console.WriteLine(" ");
        Console.WriteLine("Consider the following prompt:");
              Random random = new Random();
              int activity = prompts.Count();
              Console.WriteLine($"--- {prompts[random.Next(activity)]} ---");
        Console.WriteLine(" ");
        Console.WriteLine("Press enter to continue.");
        var userInput = Console.ReadKey();
        if(userInput.Key == ConsoleKey.Enter){
            Console.WriteLine(" ");
            Console.WriteLine(" Reflect on each of the following questions, related to this experience.");
            int k = 5;
            Console.WriteLine("You may begin in:");
            while (k > 0) {
                Console.WriteLine(k);
                Thread.Sleep(1000);
                Console.WriteLine("\R \R");
                k--;
            }
            Console.WriteLine(" ");
            Random random = new Random();
            int activity1 = questions.Count();
            Console.WriteLine($"> {questions[random.Next(activity1)]} ");
            foreach (string s in start) {
                Console.Write(s);
                Thread.Sleep(seconds*50);
                Console.Write("\R \R");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Well done!");
            Console.WriteLine($"You have completed another {seconds} seconds of Reflecting Activity.");
            foreach (string s in clock) {
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\R \R");
            }
        }  
    }
    
    /*public void Start()
    {
      string[] prompts = {"1.Think of a time when you stood up for someone else.",
                          "2 .Think of a time when you did something really difficult.",
                          "3 .Think of a time when you helped someone in need.",
                          "4 .Think of a time when you did something truly selfless."};
                          var random = new Random();
                          var index = random.Next(prompts.Count);
                           Console.WriteLine(prompts[index]);
    }
    public void Questions() 
    {
                 string[] _Questions = {"Why was this experience meaningful to you?",
                                         "Have you ever done anything like this before?",
                                          "How did you get started?",
                                           "What did you learn from this experience?",
                                           "How can you apply what you learned to other situations?",
                                           "How did you feel when it was complete?",
                                            "What made this time different than other times when you were not as successful?",
                                            "What is your favorite thing about this experience?",
                                             "What did you learn about yourself through this experience?",
                                             "How can you keep this experience in mind in the future?"};
                                              Random random = new Random();
                                              int index = random.Next(Questions.Count);
                                              string question = Questions[index];
                                              // Ask the user to enter their experience
                                              Console.WriteLine("prompt:"+ prompt);
                                              string experience = Console.ReadLine();
                                              Console.WriteLine("prompt:" + prompt);
                                              string reflection = Console.ReadLine();
                                              // Thank the user for their input
                                              Console.WriteLine("Well Done!");
    }
private const string Sequence = @"/-\|";
    private int counter = 0;
    private readonly int left;
    private readonly int top;
    private readonly int delay;
    private bool active;
    private readonly Thread thread;

    public Spinner(int left, int top, int delay = 100)
    {
        this.left = left;
        this.top = top;
        this.delay = delay;
        thread = new Thread(Spin);
        
    }

    public void Star()
    {
        active = true;
        if (!thread.IsAlive)
            thread.Start();
    }

    public void Stop()
    {
        active = false;
        Draw(' ');
    }

    private void Spin()
    {
        while (active)
        {
            Turn();
            Thread.Sleep(delay);
        }
    }

    private void Draw(char c)
    {
        Console.SetCursorPosition(left, top);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(c);
    }
    }









































