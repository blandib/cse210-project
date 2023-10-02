using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
class Program
{
    static void Main(string[] args)

    {
    Console.WriteLine("Welcome to the Journal Program!");
     Journal journal1 = new Journal();
     journal1._question = "Write";
     journal1._question1 = "Display";
     journal1._question2 = "Load";
     journal1._question3 = "Save";
     journal1._question4 = "Quit";

     Prompt myprompt = new Prompt();
     myprompt._words = {"Who was the most interesting person.?  interacted with today.?};
     {"What was the best part of my day.?};{"How did I see the hand of the Lord in my life today?};
     {"What was the strongest emotion I felt today?};
     {"If I had one thing I could do over today what would it be?"};
      Random sentences = new Random();
      int Length = Random.Next(1, 40);
      string sentence = "";
      for (int i = 0;i< Length; i ++);
      {
        int index = Random.Next(words.length);
        sentence += words[index] + " ";

      }
      sentence= char.ToUpper(sentence[0] + sentence.Substring(1, sentence.Length -2) + ".");
      myprompt._journal.Add(Journal);
      myprompt._journal.Add(Prompt);
      myprompt.Display();
      savefile(Journal);
      public static void savefile( List<prompt> prompts)
      Console.WriteLine("savefile...");
      string filename = "user.input";
      using(StreamWriter outputfile = new StreamWriter(filename) );
      foreach (Journal Journal in journal1)
      {
        outputfile.WriteLine(Journal.Display);
      } 




}
     


    
}

/