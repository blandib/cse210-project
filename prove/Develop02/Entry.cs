using System;
using System.Collections.Generic;
using System.IO;

public class Entry
    {
        // Define properties for prompt, response, and date
        public string Prompt { get; set; }
        public string Response { get; set; }
        public DateTime Date { get; set; }

        // Define a constructor for Entry
        public Entry(string prompt, string response, DateTime date)
        {
            Prompt = prompt;
            Response = response;
            Date = date;
        }

        // Define a method to save the entry to a file
        public void SaveToFile(string fileName)
        {
            // Create a StreamWriter object to write to the file
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                // Write the prompt, the response, and the date to the file
                writer.WriteLine("Prompt: " + Prompt);
                writer.WriteLine("Response: " + Response);
                writer.WriteLine("Date: " + Date.ToString("dd/MM/yyyy"));
            }
        }
    }

   


































































































































































/*class EntryManager
{
    private List<Entry> entries;
    private Random random;
    public EntryManager()
    {
        entries = new List<Entry>();
        random = new Random();
    }
     // A method to show the user a random prompt and save their response as an entry
    public void writeNewEntry()
    {
      string[] prompts = { "What is something you learned today?",
            "What are you grateful for?",
            "What was the best part of my day?",
            "What are you looking forward to?",
            "How did I see the hand of the Lord in my life today?",
            "What is something that made you smile today?",
            "What was the strongest emotion I felt today?",
            "What is a goal you have for this week?",
            "If I had one thing I could do over today, what would it be?",
            "Who was the most interesting person I interacted with today?"};
             // Choose a random prompt from the array
             int index = random.Next(prompts.Length);
             string prompt = prompts[index];
             // Display the prompt to the user
             Console.WriteLine("Prompt:"+ prompt);
              // Read the user's response from the console
              Console.WriteLine("response: ");
              string response = Console.ReadLine();
              // Get the current date and time
              DateTime date = DateTime.Now;
              // Create a new entry with the prompt, the response and the date
              Entry entry = new Entry(prompt, response, date);
               // Add the entry to the list
               entries.Add(entry);
               // Display a confirmation message to the user
               Console.WriteLine("Your entry has been saved.");
    }
    // A method to display all the entries in the list
    public void ShowAllEntries()
    {
        // Check if the list is empty
        if (entries.Count == 0)
        {
            // Display a message that there are no entries
            Console.WriteLine("You have no entries.");
        }
       
        else
        {
            Console.WriteLine("You have {0} entries.", entries.Count);
            foreach (Entry entry in entries)
            {
                Console.WriteLine("Prompt:" + entry.Prompt);
                Console.WriteLine("Response:" + entry.Response);
                Console.WriteLine("Date:" + entry.Date);
                Console.WriteLine();
            }
        }
       }
    }*/
    
    

