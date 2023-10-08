using System;
using System.IO;
using System.Collections.Generic;
class Load
{
    public static void Main(string[] args)
    {
        List<string> journal = new List<string>();
        Console.WriteLine("Enter the filename: ");
        string filename = Console.ReadLine();
        if (File.Exists(filename))
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine())!= null)
                {
                    journal.Add(line);
                }
            }
            Console.WriteLine("Loaded {0} entries from{1}",journal.Count, filename);
    
        }
        else
        {
            Console.WriteLine("The file{0} does not exist.", filename);
        }
    
    }
}