using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int gradePercentage = int.Parse(Console.ReadLine());

        // Variable to store the letter grade
        string letter = "";

        // Determine the letter grade using if-else statements
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (gradePercentage >= 70)
        {
            Console.WriteLine($"Your letter grade is {letter}");
            Console.WriteLine("Congratulations you passed the course ");
        }
        else 
        {
            Console.WriteLine($"Your letter grade is {letter}");
            Console.WriteLine("Don't be sad! Keep trying!");
        }
        string sign = "";

        if (letter == "A")
        {
            
            sign = "-"; 
        }
        else if (letter == "B")
        {
            if (gradePercentage % 10 >= 7)
                sign = "+";
            else if (gradePercentage % 10 < 3)
                sign = "-";
        }
        else if (letter == "C")
        {
            if (gradePercentage % 10 >= 7)
                sign = "+";
            else if (gradePercentage % 10 < 3)
                sign = "-";
        }
        else if (letter == "D")
        {
            if (gradePercentage % 10 >= 7)
                sign = "+";
            else if (gradePercentage % 10 < 3)
                sign = "-";
        }
        
        if (letter != "F") 
        {
            Console.WriteLine($"Your final grade is: {letter}{sign}");
        }
        else
        {
            Console.WriteLine($"Your final grade is: {letter}");
        }
}

}