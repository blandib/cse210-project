using System;
using System.IO;
using System.Collections.Generic;
 public class Load
{
   public static void LoadFile()
    {
        // Declare a list to store the journal entries
        List<string> journal = new List<string>();

        // Prompt the user for a filename
        Console.WriteLine("Enter the filename of the journal:");
        string filename = Console.ReadLine();

        // Check if the file exists
        if (File.Exists(filename))
        {
            // Load the journal from the file
            using (StreamReader reader = new StreamReader(filename))
            {
                // Read each line and add it to the journal list
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    journal.Add(line);
                }
            }

            // Display the number of entries loaded
            Console.WriteLine("Loaded {0} entries from {1}", journal.Count, filename);
        }
        else
        {
            // Display an error message if the file does not exist
            Console.WriteLine("The file {0} does not exist.", filename);
        }
    }

}