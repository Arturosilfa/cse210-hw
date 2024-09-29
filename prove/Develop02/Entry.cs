using System;

namespace JournalProgram
{
    class Entry
    {
        // getting information for the user
        public DateTime Date { get; set; }
        public string Prompt { get; set; }
        public string Answer { get; set; }
    
        // Iterate through all entries in the journal and display them to the screen.
        public Entry(string date, string prompt, string answer)
        {
            this.Date = DateTime.Parse(date);
            this.Prompt = prompt;
            this.Answer = answer;
        }

    public override string ToString()
        {
            return $"{Date:yyyy-MM-dd} - {Prompt}\nAnswer: {Answer}\n";
        }
    }
}