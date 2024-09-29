using System;
using System.Collections.Generic;

namespace JournalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            bool continueRunning = true;

            while (continueRunning)
            {
                Console.WriteLine("Please select one of the following options: ");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        journal.AddEntry();
                        break;

                    case "2":
                        journal.DisplayEntries();
                        break;

                    case "3":
                        journal.LoadFromFile();
                        break;

                    case "4":
                        journal.SaveToFile();
                        break; 

                    case "5":
                        continueRunning = false;
                        break;
                    
                    default:
                        Console.WriteLine("Invalid option. Choose again.");
                        break;
                }
            }
        }
    }
}