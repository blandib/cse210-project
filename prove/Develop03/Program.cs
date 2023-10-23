using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
         // Declare a variable to store the user input
        string input = "";

        // Declare a variable to store the scripture reference
        string reference = "John 3:16";

        // Declare a variable to store the scripture text
        string text = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";

        // Use a loop to repeat until the user types quit
        while (input != "quit")
        {
            // Clear the console screen
            Console.Clear();

            // Display the scripture reference and text
            Console.WriteLine(reference + "\n" + text);

            // Prompt the user to press the enter key or type quit
            Console.WriteLine("\nPress the enter key or type quit.");

            // Read the user input
            input = Console.ReadLine();
        }
        // Remove the word from the list
                words.Remove(word);
                 // Hide the word in the scripture by replacing it with underscores
                scripture = scripture.Replace(word, new string('_', word.Length));
                
                // Show the updated scripture to the user
                Console.WriteLine("Scripture: " + scripture);
            }
        }
        
        // When all words are hidden, end the program
        Console.WriteLine("All words are hidden. The program ends.");
    
    
    
    
    
    
    


    