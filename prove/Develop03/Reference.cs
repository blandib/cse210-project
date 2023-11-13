using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;
    }
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }
    public string GetReferenceText()
    {
        if (this.GetEndVerse() != 0)
        {
            return ($"{this.GetBook()} {this.GetChapter()}:{this.GetVerse()}-{this.GetEndVerse()}");
        }
        else
        {
            return ($"{this.GetBook()} {this.GetChapter()}:{this.GetVerse()}");
        }
    }
    public string GetBook()
    {
        return _book;
    }
    public int GetChapter()
    {
        return _chapter;
    }
    public int GetVerse()
    {
        return _verse;
    }
    public int GetEndVerse()
    {
        return _endVerse;
    }
    public void SetBook(string book)
    {
        _book = book;
    }
    public void SetChapter(int chapter)
    {
        _chapter = chapter;
    }
    public void SetVerse(int verse)
    {
        _verse = verse;
    }
    public void SetEndVerse(int endVerse)
    {
        _endVerse = endVerse;
    }
}


























































































































































































































































































































 /*using System.Text;
using System.IO;

namespace Develop03;

// Reference class keeps track of a scripture reference, including references that span multiple verses.
public class Reference
{
	private string reference;
    string pattern = @"(?<book>\w+\.?\s?)(?<chapter>\d+):(?<verses>\d+-\d+)";
	references reference = new references(pattern)
	string input = "Proverbs 3:5-6";
	Match match = reference.Match(input);
	if (match.Success)
	{
	string book = match.Groups["book"].Value;
    string chapter = match.Groups["chapter"].Value;
    string verses = match.Groups["verses"].Value;
	Console.WriteLine($"Book: {book}");
    Console.WriteLine($"Chapter: {chapter}");
    Console.WriteLine($"Verses: {verses}");
	}
else
{
    
    Console.WriteLine("Invalid scripture reference.");
}
	// Sets reference
	string references = "book, chapter, verses";
	ref string reference = ref references;
	reference = input;
	console.WriteLine (references);
	console.WriteLine(reference)
	public Reference(string reference) => this.reference = reference;
     string Reference = null; 
    if (string.IsNullOrEmpty(Reference))
{
    throw new ArgumentException ("Reference cannot be null");
}

{
    this.reference = reference;
}
	// Returns reference
	public string Value
	{
		get { return this.reference; }
	}
	public override string ToString() => reference;
	$"{book}{Chapter} {verses}".Trim();
}*/