using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your grade percentage: ");
        int gradePercentage = int.Parse(Console.ReadLine());

        // Determine the letter grade
        string letter = "";
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

        // Determine if the user passed the course
        if (gradePercentage >= 70)
        {
            Console.WriteLine($"Your letter grade is {letter}. Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine($"Your letter grade is {letter}. Keep working for next time!");
        }

        // Stretch Challenge: Determine the grade sign
        string sign = "";
        int lastDigit = gradePercentage % 10;
        
        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }

        // Handle exceptional cases for A, F grades
        if (letter == "A" && sign == "+")
        {
            letter = "A+";
            sign = "";
        }
        else if (letter == "F" && (sign == "+" || sign == "-"))
        {
            letter = "F";
            sign = "";
        }

        // Display both the grade letter and sign
        Console.WriteLine($"Your final grade is {letter}{sign}");
    }
}
