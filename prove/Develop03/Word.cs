using System;

public class Word
{
    private string _word;
    private bool _visibility;
    private Word()
    {
        _word = null;
        _visibility = true;
    }
    public Word(string word, bool visibility = true)
    {
        _word = word;
        _visibility = visibility;
    }
    public void Hide()
    {
        _visibility = false;
        string blanks = new string('_', _word.Length);
        _word = _word.EndsWith(".") ? blanks = blanks.Remove(0, 1) + ".":
                _word.EndsWith(",") ? blanks = blanks.Remove(0, 1) + ",":
                _word.EndsWith(":") ? blanks = blanks.Remove(0, 1) + ":":
                _word.EndsWith(";") ? blanks = blanks.Remove(0, 1) + ";":
                blanks;
    }
    public string GetWord()
    {
        return _word;
    }
    public bool GetVisibility()
    {
        return _visibility;
    }
    public void SetWord(string word)
    {
        _word = word;
    }
    public void SetVisibility(bool visibility)
    {
        _visibility = visibility;
    }
}





































































































































































































































































/*using System;
public class Word
{
    // A field to store the text of the word
    private string text;
    // A field to store whether the word is hidden or not
    private bool hidden;
    // A constructor that takes the text of the word as a parameter
    public Word(string text)
    {
        // Assign the text to the field
        this.text = text;
        // Set the hidden field to false by default
        this.hidden = false;
    }
    // A method to get the text of the word
    public string GetText()
    {
        // Return the text field
        return this.text;
        // A method to set the text of the word
    }
     // A method to set the text of the word
    public void SetText(string newText);
    
        // Assign the new text to the field
    this.text = newText;
    
    // A method to get whether the word is hidden or not
    public bool IsHidden()
    {
        // Return the hidden field
        return this.hidden;
    }
    // A method to set whether the word is hidden or not
    public void SetHidden(bool newHidden)
    {
        // Assign the new hidden value to the field
        this.hidden = newHidden;
    }
}*/

/*using System.ComponentModel.Design.Serialization;
using System.Text.RegularExpressions;

namespace Develop03;

// Keeps track of an individual word in a scripture. When hidden, it returns underscores the same length of the 
// word.
public class Word
{
	private string word;
	private bool isVisible = true;

	public Word(string word)
	{
		this.word = word;
	}

	public void hide() { isVisible = false; }

	public bool getIsVisible() => isVisible;

	// Returns the word if visible, underscores of the same length if hidden.
	public override string ToString()
	{
		return isVisible ? word : Regex.Replace(word, "[a-zA-Z]", "_");
	}
}*/