/*using System;
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
        Console.WriteLine("All words are hidden. The program ends.");*/
 /*using System;
using Develop03;

class Program
{
    static string verse = @"
My fathers, having turned from their righteousness, and from the holy commandments which the Lord their God 
had given unto them, unto the worshiping of the gods of the heathen, utterly refused to hearken to my voice; 

For their hearts were set to do evil, and were wholly turned to the god of Elkenah, and the god of Libnah, 
and the god of Mahmackrah, and the god of Korash, and the god of Pharaoh, king of Egypt;";
    static string reference = "Abraham 1:5-6";

    static void Main(string[] args)
    {
        // Instantiate a Scripture with a verse and reference
        public string Verse { get; set; }
        public string Reference { get; set; }
        public Scripture(string verse, string reference)
    {
        // Assign the parameters to the fields
        Verse = verse;
        Reference = reference;
    }

        Scripture scripture = new Scripture(verse, new Reference(reference), 3);
        string input = "";

        do
        {
            // Clear the screen before displaying scripture
            Console.WriteLine("For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

            Console.Clear();
            // Write out scripture and verse
             list<Scripture> Scripture = new list<Scripture>();
             Scripture.Add( new Scripture {reference = "John 3:16" verse= "For God so loved the world that He gave His one and only Son, that everyone who believes in Him shall not perish but have eternal life. "})
             Scripture.Add( new Scripture { reference = "Abraham 1:5-6" verse = "My fathers, having turned from their righteousness, and from the holy commandments which the Lord their God had given unto them, unto the worshiping of the gods of the heathen, utterly refused to hearken to my voice; For their hearts were set to do evil, and were wholly turned to the god of Elkenah, and the god of Libnah, and the god of Mahmackrah, and the god of Korash, and the god of Pharaoh, king of Egypt;";})
            foreach(Scripture scriptures in scripture)
            Console.Write(scripture.ToString());
            // Get user's input
            Console.WriteLine("Press enter!")
            input = Console.ReadLine();
        }
        while (!input.ToUpper().Equals("QUIT") && !scripture.isFinished());
        // Prompt the user to enter something or type quit to end the program
            Console.WriteLine("Press enter to continue or type quit to end the program.");

            // Read the user input and store it in the variable
            input = Console.ReadLine();

            // If the user input is not quit, print it back to the console
            if (input != "quit")
            {
                Console.WriteLine("You entered: " + input);
            }
        }

        // Print a goodbye message when the loop ends
        Console.WriteLine("Goodbye!");
    }*/

    
    
    
    
    
    
    


    