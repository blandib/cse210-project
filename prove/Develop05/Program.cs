using System;
using System.Collections.Generic;
using System.Linq;
Console.WriteLine("Hello Develop05 World!");
DisplayWelcomeMessage();
int choice = -1;
Game game = new Game();
do
{
    Console.WriteLine($"You have {game.getPoints()} points");
    ShowMenu();
    Console.Write("Please Type The Number Corresponding With Your Choice: ");
    choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            game.Create();
            break;
        case 2:
            game.List();
            break;
        case 3:
            game.Save();
            break;
        case 4:
            game.Load();
            break;
        case 5:
            game.Progress();
            break;
        case 0:
            DisplayEndMessage();
            break;
        default:
            Console.Clear();
            Console.WriteLine("Please Select a correct value");
            break;
    }

} while (choice != 0);

void DisplayWelcomeMessage()
{
    Console.WriteLine("Welcome to the Gamification Program!");
}

void DisplayEndMessage()
{
    Console.Clear();
    Console.WriteLine("Good Bye");
}

void ShowMenu()
{
    Console.Write("""

    Menu Options :
      1) Create new Goal
      2) List of Goals
      3) Save Goals
      4) Load Goals
      5) Record Progress
      6) Quit

    """);

}
