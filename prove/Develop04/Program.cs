//namespace Develop04;
using System;
using System.ComponentModel;
using System.Globalization;

using System;


DisplayWelcomeMessage();
int choice = -1;
do
{
    ShowMenu();
    Console.Write("Please Type The Number Corresponding With Your Choice: ");
    choice = int.Parse(Console.ReadLine());


    Activity activity;
    switch (choice)
    {
        case 1:
            activity = new BreathingActivity();
            activity.Start();
            break;
        case 2:
            activity = new ReflectionActivity();
            activity.Start();
            break;
        case 3:
            activity = new ListingActivity();
            activity.Start();
            break;
        case 4:
            activity = new ReminderActivity();
            activity.Start();
            break;
        case 0:
            // display good bye message
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
    Console.WriteLine("Welcome to the Mindfulness program!");
}

void DisplayEndMessage()
{
    Console.Clear();
    Console.WriteLine("Good Bye");
}

void ShowMenu()
{
    Console.Clear();
    Console.Write("""
            Would you like to:

            1) Start Breathing Activity
            2) Start Reflection Activity
            3) Start Listing Activity
            4) Start Remimder Activity
            0) Exit

            """);
}





































































































































































