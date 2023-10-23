using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        // Create an instance of the EntryManager class
        EntryManager manager = new EntryManager();
        // A variable to store the user's choice
        int choice;
         // A loop to repeat until the user chooses to exit
         do
         {
            // Display a menu of options to the user
            Console.WriteLine("Welcome To The Journal Program. Choose an Option:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display: ");
            Console.WriteLine("3. Load: ");
            Console.WriteLine("4. Save: ");
            Console.WriteLine("5. Quit: ");
            // Read the user's choice from the console
            choice = int.Parse(Console.ReadLine());
            // Perform an action based on the user's choice
            switch (choice)
            {
                case 1:
                manager.writeNewEntry();
                break;
                case 2:
                manager.writeNewEntry();
                break;
                case 3:
                manager.writeNewEntry();
                break;
                case 4:
                manager.ShowAllEntries();
                break;
                case 5:
                Console.WriteLine("Thank you for using Journal.Goodbye!");
                break;
                default:
                Console.WriteLine("Invalid option. Please choose again.");
                break;
            }
            Console.WriteLine();
         } while (choice != 5);
         
            List<string> journal = new List<string>();
            journal.Add("What did you learned today? ");
            journal.Add("What else did you do today");
            foreach(string entry in journal)
            {
                Console.WriteLine(entry);
            }
 }
 /*public static void menu()
 {
  int choice = 0;
  while (choice != 5)
  {
    Console.WriteLine("Please choose one of the following options:");
    Console.WriteLine("1. Write:");
    Console.WriteLine("2. Display: ");
    Console.WriteLine("3. Load: ");
    Console.WriteLine("4. Save: ");
    Console.WriteLine("5. Quit: ");
    Console.WriteLine("Enter your choice: ");
    bool valid = int.TryParse(Console.ReadLine(), out choice);
    if (!valid || choice < 1|| choice> 5)
    {
        Console.WriteLine("Invalid choice. Please try again.");
        continue;
    }
    Console.WriteLine("Thank for using the Journal. Goodbye!");
  }
 }*/
}