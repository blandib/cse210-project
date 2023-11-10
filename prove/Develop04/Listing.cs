using System;
using System.Collections.Generic;
using System.IO;
//namespace Develop04;

public class Listing()
 private List <string> start = new List<string> {"|", "/", "—", "\\", "|", "/", "—", "\\"};
    private List <string> prompts1 = new List<string> {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
    private List <string> items = new List<string> ();
    private Random random;
    public void ListActivity() {
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        string input = Console.ReadLine();
        int seconds = int.parse(input);
         Console.Write("Get ready...");
        foreach (string s in start) {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\R \R");
        }
         Console.WriteLine(" ");
        Console.WriteLine("Consider the following prompt:");
        Random random = new Random();
        int activity2 = prompts1.Count();
        Console.WriteLine($"--- {prompts1[random.Next(activity2)]} ---");
        int k = 5;
         Console.WriteLine("You may begin in:");
            while (k > 0) {
                Console.WriteLine(k);
                Thread.Sleep(1000);
                Console.WriteLine("\R \R");
                k--;

    }
     DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(secondsInt);
            while (DateTime.Now < endTime) {
                Console.WriteLine("> ");
                string item = Console.ReadLine();
                items.Add(item);
            }
            Console.WriteLine(" ");
            Console.WriteLine($"You listed {items.Count()} items");
            Console.WriteLine(" ");
            Console.WriteLine("Well done!");
            foreach (string s in start) {
                Console.WriteLine(s);
                Thread.Sleep(1000);
                Console.WriteLine("\R \R");
            }
    }











































