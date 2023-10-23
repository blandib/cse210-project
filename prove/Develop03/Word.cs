using System;
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
}