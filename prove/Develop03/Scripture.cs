using System;
public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;
    public Scripture(string book, string chapter, string verse, string verseText)
    {
        if (verse.Contains("-"))
        {
            string[] multiVerse = verse.Split("-");
            _reference = new Reference(book, int.Parse(chapter), int.Parse(multiVerse[0]), int.Parse(multiVerse[1]));
        }
        else
        {
            _reference = new Reference(book, int.Parse(chapter), int.Parse(verse));
        }
        this.SetWords(verseText);
    }
    public bool AllHidden()
    {
        foreach (Word word in _words)
        {
            if (word.GetVisibility())
            {
                return false;
            }
        }
        return true;
    }
    public void DisplayScripture()
    {
        Console.Clear();
        Console.Write($"{GetRefrence()} -> ");
        foreach (Word word in GetWords())
        {
            Console.Write($"{word.GetWord()} ");
        }
        Console.WriteLine();
    }
    public void HideWords(int wordCount = 1)
    {
        Random random = new Random();
        int randIndex = 0;
        int wordsRemoved = 0;
        do
        {
            randIndex = random.Next(0, _words.Count());
            if (_words[randIndex].GetVisibility())
            {
                _words[randIndex].Hide();
                wordsRemoved++;
            }
        }
        while (!AllHidden() && wordsRemoved != wordCount);
    }
    public string GetRefrence()
    {
        return _reference.GetReferenceText();
    }
    public List<Word> GetWords()
    {
        return _words;
    }
    public void SetRefrence(Reference reference)
    {
        _reference = reference;
    }
    public void SetWords(string wordsString)
    {
        foreach (string word in wordsString.Split(" "))
        {
            Word newWordOBJ = new Word(word);
            _words.Add(newWordOBJ);
        }
    }
}



















































































































































































































































































/*using System.Text;

namespace Develop03;

// Represents a scripture verse and reference. It hides a random number of visible words before displaying.
public class Scripture
{
  private List<Word> verse = new List<Word>();
  private Reference reference;
  private Random random = new Random();
  private int wordsToHide;
  private bool allowHiding = false;

  public Scripture(string scripture, Reference reference)
    : this(scripture, reference, 3)
  {
   Reference ref = new Reference("John", 3, 16);
   Scripture references = new Scripture("For God so loved the world that He gave His one and only Son, that everyone who believes in Him shall not perish but have eternal life.", ref);
   Console.WriteLine(references.Scripture);
   Console.WriteLine(references.Reference.Book);
   Console.WriteLine(references.Reference.Chapter); 
   Console.WriteLine(references.Reference.Verse);
   Console.WriteLine(references.IntValue);
  }

  // Initializes a Scripture with a verse (scripture) and reference. It also allow the caller to specify
  // the number of visible words that should be hidden each time it is displayed.
  public Scripture(string scripture, Reference reference, int wordsToHide)
  {
    parseScripture(scripture);
    this.reference = reference;
    this.wordsToHide = wordsToHide;
    Verse = verse;
    Reference = reference;
    HiddenWords = hiddenWords;
    

  }

  // Formats the verse and reference into a string. It also prevents hiding the first time it is displayed
  // so that it shows the entire verse.
  public override string ToString()
  {
    // Only hide after showing the verse once
    if (allowHiding) hideWords();

    StringBuilder sb = new StringBuilder();
    sb.AppendLine(reference.ToString());
    sb.AppendLine();
    sb.Append(String.Join(" ", verse.Select(word => word.ToString())));
    sb.AppendLine();
    sb.AppendLine();
    sb.AppendLine("Press enter to hide words, or 'quit' to exit.");

    // Verse has been shown so allow hiding when showing again
    allowHiding = true;

    return sb.ToString();
  }

  // Is true when all Word in the verse have been hidden
  public bool isFinished()
  {
    var count = verse.Count(word => word.getIsVisible());
    return count == 0;
  }

  // Hides a random number of visible Words. The number of Word to hide is determined by wordsToHide.
  private void hideWords()
  {
    // Get all visible Words
    List<Word> visibleWords = verse.FindAll(word => word.getIsVisible());

    // Hide some of the visible Words randomly
    for (int i = 0; i < Math.Min(wordsToHide, visibleWords.Count); i++)
    {
      int index = random.Next(visibleWords.Count);
      visibleWords[index].hide();
      visibleWords = verse.FindAll(word => word.getIsVisible());
    }
  }

  // Parses a scripture verse (string) into Words
  private void parseScripture(string scripture)
  {
    List<string> words = scripture.Split(" ").ToList();
    foreach (string word in words)
    {
      this.verse.Add(new Word(word.Trim()));
    }
  }
}*/
