using System;
using System.IO;

public class Menu
{

         
 public static void menu()
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
 }   
}

  