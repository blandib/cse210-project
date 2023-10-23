using System;
using System.IO;
using System.IO.Enumeration;

public class Save
{
     public void Display()
    
    
    {    
        var journal = new List<string>();
        // Prompt the user for a filename
        Console.WriteLine("Enter The File name to save in the Journal: ");
        
        string filename = Console.ReadLine();

        // Save the journal to the file location
        try
        {
            File.WriteAllLines(filename, journal);
            Console.WriteLine("Journal saved successfully.");
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred while saving the journal: " + e.Message);
        }
    }
}
        
    
