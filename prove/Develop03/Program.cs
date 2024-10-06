using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            scripture.Display();  
            Console.WriteLine("\nPress 'Enter' to hide any word or write quit to finish");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords();  
        }

        Console.WriteLine("Every word has been hide, try again!");
    }
}

