
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