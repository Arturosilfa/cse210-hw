using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.Write ("What is the magic number? ");
        int magicnumber = int.Parse (Console.ReadLine());
    
        int guess = -1;
        
        while (guess != magicnumber)
        {
            Console.Write ("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            
            if (guess < magicnumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicnumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}