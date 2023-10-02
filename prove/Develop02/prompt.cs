using System;

public class Prompt

{
    public string _words;
    public List<Journal> _journal = new List<Journal>();

    public void Display();
    {
         Console.WriteLine($"Word: {_words}");
         Console.WriteLine($"Journal:");
         foreach(Journal Journal in _journal);
        {
          Journal.Display();
        }
    }
}



















    /*string[] words = {"Who", "was" ,"the" ,"most" ,"interesting","person", "I", "interacted", "with", "today?","What", "was", "the", "best", "part", "of", "my", "day?","How", "did", "I", "see", "the", "hand", "of", "the", "Lord", "in", "my","life", "today?",
         "What", "was", "the", "strongest", "emotion", "I", "felt", "today?",
         "If", "I", "had", "one", "thing", "I", "could", "do", "over", "today,", "what", "would", "it", "be?"};*/

   
    