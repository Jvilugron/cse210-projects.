using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Scripture Memorization Program!");
        Console.Write("Enter the scripture reference (e.g., 'John 3:16'): ");
        string reference = Console.ReadLine();

        Console.Write("Enter the scripture text: ");
        string text = Console.ReadLine();

        Scripture scripture = new Scripture(reference, text);

        Console.Clear();
        scripture.DisplayScripture();

        while (true)
        {
            Console.WriteLine("Press Enter to hide a random word or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;
            else
                scripture.HideRandomWord();
        }
    }
}
