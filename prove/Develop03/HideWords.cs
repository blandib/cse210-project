/*using System;
using System.Collections.Generic;
public class HideWords
{
    // The scripture to hide words from
        string scripture = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        
        // Split the scripture into words and store them in a list
        List<string> words = new List<string>(scripture.Split(' '));
        
        // A random number generator
        Random random = new Random();
        
        // A loop to hide words until all are hidden
        while (words.Count > 0)
        {
            // Prompt the user to enter a word
            Console.WriteLine("Enter a word:");
            string input = Console.ReadLine();
            
            // Check if the input is a valid word in the scripture
            if (words.Contains(input))
            {
                // Remove the word from the list
                words.Remove(input);
                
                // Hide the word in the scripture by replacing it with underscores
                scripture = scripture.Replace(input, new string('_', input.Length));
                
                // Show the updated scripture
                Console.WriteLine("Scripture: " + scripture);
            }
            else
            {
                // Show an error message
                Console.WriteLine("Invalid word. Try again.");
            }
            
            // If there are still words left, randomly show a hint for one of them
            if (words.Count > 0)
            {
                // Pick a random word from the list
                string hint = words[random.Next(words.Count)];
                
                // Show the first and last letter of the word as a hint
                Console.WriteLine("Hint: The word starts with '{0}' and ends with '{1}'.", hint[0], hint[hint.Length - 1]);
            }
        }
        
        // Congratulate the user for Memorizer all words
        Console.WriteLine("Congratulations! You have Memorizer all words in the scripture.");
    }*/

