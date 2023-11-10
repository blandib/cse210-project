using System;
using System.Threading;
using System.Diagnostics;
                                                                                                  
 public class Breath;
    {    
   
    private List <string> start = new List<string> {"|", "/", "—", "\\", "|", "/", "—", "\\"};
        private void Welcome() {   
            // The standard starting message 
            Console.WriteLine("Welcome to the Breathing Activity!");
            Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
            string input = Console.ReadLine();
            int seconds = int.parse(seconds);
            Console.WriteLine("Get ready...");
            foreach (string s in start) {
                Console.WriteLine(s);
                Thread.Sleep(1000);
                Console.WriteLine("\R \R");
            }
            console.WriteLine("");
            int c = 3;
            while (c > 0) {
                double k = Math.Ceiling(seconds * 0.13);
                Console.WriteLine("Breathe in ...");
                while (k > 0) {
                    Console.WriteLine(k);
                    Thread.Sleep(1000);
                    Console.WriteLine("\R\R");
                    k--;
                }
                double l = Math.Ceiling(seconds * 0.2);
                Console.WriteLine("Breathe out...");
                while (l > 0) {
                    Console.WriteLine(l);
                    Thread.Sleep(1000);
                    console.WriteLine("\R\R");
                    l--;
                }
               c--;
            }
            Console.WriteLine("Well done!");
            Console.WriteLine($"You have complete another {seconds} seconds of Breathing Activity.");
            foreach (string s in start) {
                Console.WriteLine(s);
                Thread.Sleep(1000);
                Console.WriteLine("\R\R");
                
            }
        }
    }








       