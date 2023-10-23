using System;
using System.Collections.Generic;
/*public class Scripture
{
    public string Reference { get; set; }
    public string Text { get; set; }
}
    // Constructor that takes the reference and text as parameters
    public Scripture(string reference, string text)
    {
        Reference = reference;
        Text = text;
    }

    Scripture john = new Scripture("John 3:16-18", new string[] {
    "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.",
    "For God did not send his Son into the world to condemn the world, but to save the world through him.",
    "Whoever believes in him is not condemned, but whoever does not believe stands condemned already because they have not believed in the name of God's one and only Son."
});*/
//{
    public class Scripture
    {
        // Properties
        public string Reference {get; set;}
        public string Text {get; set;}
        // Constructor
        public Scripture(string reference, string text)
        {
            Reference = reference;
            Text = text;
       }
        // Method
    public string HideWords(int n)
    {
            // Split the text into words
            string [] words - Text.Split("");
            Create a list to store the indices of the words to hide
            list<int> indices = new list<int>();
            // Create a random object
            Random random = new Random();
             Loop until n words are selected
            while (indices.Count < n)
            {
                // Generate a random index between 0 and the length of the words array
             int index = random.Next(0, words.length);
             If the index is not already in the list, add it
                if (! indices.Contains(index))
                {
                  indices.add(index);
                }
            }
                //Loop through the words array
                for (int i = 0; i <words.length; i++)
            {
                 If the index is in the list, replace the word with underscores
                if (indices.Contains(i))
            {
                   words[i] = new string("_", words[i].length);
                }
            }
            // Join the words back into a string and return it
            return string.Join("", words);
        } 
    }
