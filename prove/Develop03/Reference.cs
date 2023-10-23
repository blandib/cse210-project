using System;
using System.Collections.Generic;
using System.Linq;
 public class Reference
 {
    // A string array that contains the scripture to display
    static string[] scripture = new string[] {
        "For God so loved the world,",
        "that he gave his only begotten Son,",
        "that whosoever believeth in him",
        "should not perish, but have everlasting life."
    };

    // A list of integers that stores the indices of the hidden words
    static List<int> hiddenWords = new List<int>();

    // A random number generator
    static Random random = new Random();

    static void Main(string[] args)
    {
        // Display the scripture for the first time
        DisplayScripture();

        // Wait for the user to press the enter key
        Console.ReadLine();

        // Hide a few random words in the scripture
        HideWords();

        // Clear the console screen
        Console.Clear();

        // Display the scripture again
        DisplayScripture();
    }

    // A method that displays the scripture with hidden words replaced by underscores
   public static void DisplayScripture()
    {
        // Loop through each line of the scripture
        for (int i = 0; i < scripture.Length; i++)
        {
            // Split the line into words by spaces and punctuation
            string[] words = scripture[i].Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

            // Loop through each word in the line
            for (int j = 0; j < words.Length; j++)
            {
                // Check if the word is hidden or not
                if (hiddenWords.Contains(i * 100 + j))
                {
                    // Replace the word with underscores
                    Console.Write(new string('_', words[j].Length));
                }
                else
                {
                    // Display the word as it is
                    Console.Write(words[j]);
                }

                // Display a space after each word
                Console.Write(" ");
            }

            // Display a new line after each line of the scripture
            Console.WriteLine();
        }
    }

    // A method that hides a few random words in the scripture and adds their indices to the list
    private static void HideWords()
    {
        // Decide how many words to hide (between 1 and 4)
        int numWords = random.Next(1, 5);

        // Loop until enough words are hidden
        while (hiddenWords.Count < numWords)
        {
            // Pick a random line of the scripture (between 0 and 3)
            int line = random.Next(0, 4);

            // Split the line into words by spaces and punctuation
            string[] words = scripture[line].Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

            // Pick a random word in the line (between 0 and words.Length - 1)
            int word = random.Next(0, words.Length);

            // Calculate the index of the word as line * 100 + word
            int index = line * 100 + word;

            // Check if the word is already hidden or not
            if (!hiddenWords.Contains(index))
            {
                // Add the index to the list of hidden words
                hiddenWords.Add(index);
            }
        }
    }
}