using System;
using System.Collections.Generic;
using System.IO;

namespace JournalProgram
{
    class Journal
    {
        private List<Entry> entries = new List<Entry>();
        private List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
};

        private Random random = new Random();

        public void AddEntry()
        {
            string prompt = GetRandomPrompt();
            Console.WriteLine($"Prompt: {prompt}");
            Console.Write("Your answer is: ");
            string response = Console.ReadLine();
            string date = DateTime.Now.ToString("yyyy-MM-dd");

            Entry newEntry = new Entry(date, prompt, response);
            entries.Add(newEntry); 
            Console.WriteLine("Entry added!");
        }

        private string GetRandomPrompt()
        {
            int index = random.Next(prompts.Count);
            return prompts[index];
        }

        public void DisplayEntries()
        {
            foreach (Entry entry in entries)
            {
                Console.WriteLine(entry);
            }
        }

        public void SaveToFile()
        {
            Console.Write("What is the filename? ");
            string filename = Console.ReadLine();
            
            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    foreach (Entry entry in entries)
                    {
                        writer.WriteLine($"{entry.Date}~|~{entry.Prompt}~|~{entry.Answer}");
                    }
                }
                Console.WriteLine("Entries saved to file successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving to file: {ex.Message}");
            }
        }

        public void LoadFromFile()
        {
            Console.Write("Enter the filename to load: ");
            string filename = Console.ReadLine();

            if (File.Exists(filename))
            {
                entries.Clear();
                string[] lines = File.ReadAllLines(filename);
                foreach (string line in lines)
                {
                    string[] parts = line.Split("~|~");
                    if (parts.Length == 3)
                    {
                        Entry entry = new Entry(parts[0], parts[1], parts[2]);
                        entries.Add(entry);
                    }
                }
                Console.WriteLine("Entries loaded from file successfully.");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}
