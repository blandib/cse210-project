using System;
using System.Collections.Generic;
using System.IO;


class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public DateTime Date { get; set; }
}


class Program

   
  static void Main(string[]args)
  {
    Console.WriteLine("Welcome to Journal Program!");
    Journal journal1 = new Journal();
     journal1._question = "Write";
     journal1._question1 = "Display";
     journal1._question2 = "Load";
     journal1._question3 = "Save";
     journal1._question4 = "Quit";
     
      List<Journal> journals = new List<Journal>();
     
     List<prompts> prompt = new List<prompts>{
      "Who was the most interesting person I interacted with today?",
      "What was the best part of my day?",
      "How did I see the hand of the Lord in my life today?",
      "What was the strongest emotion I felt today?",
      "If I had one thing I could do over today, what would it be?",
      "What did you learn today?",
        "What was your favorite part of the day?",
        "What are you grateful for today?",
         "What is something you want to improve on?"
     };
      // Use a random number generator to select a prompt
       Random randomGenerator = new Random();
        int index = randomGenerator.Next(prompts.Count);
        string prompt = prompts[index];

        // Display the selected prompt to the user and prompt them for their response
        Console.WriteLine(prompt);
        string respons = Console.ReadLine();

        // Save the user's response, the prompt, and the date as an entry
        DateTime date = DateTime.Now;
        string entry = $"{date}: {prompt}-{respons}";

         /*Console.WriteLine($"Entry saved: {entry}");*/

          Entry Entry = new Entry()
        {
            Prompt = prompt,
            Response = respons,
            Date = DateTime.Now
        };

        List<Entry> entries = new List<Entry>();
        entries.Add(Entry);

        Console.WriteLine("Journal Entries:");
        foreach (Entry e in entries)
        {
            Console.WriteLine($"Prompt: {e.Prompt}");
            Console.WriteLine($"Response: {e.Response}");
            Console.WriteLine($"Date: {e.Date}");
            Console.WriteLine();
        }

        Console.ReadLine();  
    }
    SaveToFile(Journal);
    public static void SaveToFile(List<Entry> entries)
       Console.WriteLine("Please Save the file....")
    {
      string filename = "journal.txt";

      using (StreamWriter outputfile = new StreamWriter(filename))
       {
        foreach(Entry in Journal)
        {
          
          outputfile.WriteLine(Entry);
        }
        Console.WriteLine("Journal saved to file:" + filename);
      }
    }
    Console.WriteLine("Enter filename: ");
    string filename = Console.ReadLine();
    public static List<Journal> Readfile()
   {
    Console.WriteLine("Reading List from file...")
    List<Journal> journals = new List<Journal>();
    string filename = "journal.txt";
    string[] lines = System.IO.File.ReadAlllines(filename);
    foreach (string line in lines)
    {
      Console.WriteLine(line)
    }
    {
      
    }
    return journals
   }
     bool showMenu = prompts;
        while (showMenu)
        {
            showMenu = MainMenu();
        }

    public static bool MainMenu()
    {
      Console.Clear();
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1) Write 1");
        Console.WriteLine("2) Display 2");
        Console.WriteLine("3) Laod 3");
        Console.WriteLine("4)  Save 4");
        Console.WriteLine("5) Quict 5");
        Console.Write("\r\nSelect an option: ");
        
        switch (Console.ReadLine())
        {
            case "1":
                Console.WriteLine("You selected Option 1");
                Console.ReadLine();
                return prompts;
            case "2":
                Console.WriteLine("You selected Option 2");
                Console.ReadLine();
                return prompts;
            case "3":
            Console.WriteLine("You selected Option 3");
                Console.ReadLine();
                return prompts;
                case "4":
            Console.WriteLine("You selected Option 4");
                Console.ReadLine();
                return prompts;
                case "5":
            Console.WriteLine("You selected Option 5");
                Console.ReadLine();
            default:
                return true;
        }
    }

    {
}


    
  
