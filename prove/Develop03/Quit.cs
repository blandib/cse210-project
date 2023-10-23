using System;
public class Quit
{
     // Declare a variable to store the user input
        string input = "";

        // Start a while loop that runs until the user types quit
        while (input != "quit")
        {
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
    }

