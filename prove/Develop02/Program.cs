using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Program
{
    static Journal journal = new Journal();

    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("Journal Program Menu");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        WriteNewEntry();
                        break;
                    case 2:
                        DisplayJournal();
                        break;
                    case 3:
                        SaveJournalToFile();
                        break;
                    case 4:
                        LoadJournalFromFile();
                        break;
                    case 5:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }

    static void WriteNewEntry()
    {
        Console.Clear();
        Console.WriteLine("Write a New Entry");

        string prompt = Journal.GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        JournalEntry entry = new JournalEntry(prompt, response, DateTime.Now);
        journal.AddEntry(entry);

        Console.WriteLine("Entry saved successfully!");
    }

    static void DisplayJournal()
    {
        Console.Clear();
        Console.WriteLine("Journal Entries");
        foreach (var entry in journal.Entries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}");
            Console.WriteLine();
        }
    }

    static void SaveJournalToFile()
    {
        Console.Clear();
        Console.Write("Enter a filename to save the journal: ");
        string filename = Console.ReadLine();

        if (!string.IsNullOrEmpty(filename))
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var entry in journal.Entries)
                {
                    writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
                }
            }

            Console.WriteLine("Journal saved to file successfully.");
        }
        else
        {
            Console.WriteLine("Invalid filename. Please try again.");
        }
    }

    static void LoadJournalFromFile()
    {
        Console.Clear();
        Console.Write("Enter a filename to load the journal: ");
        string filename = Console.ReadLine();

        if (!string.IsNullOrEmpty(filename) && File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            journal.LoadFromLines(lines);

            Console.WriteLine("Journal loaded from file successfully.");
        }
        else
        {
            Console.WriteLine("File not found or invalid filename. Please try again.");
        }
    }
}

class Journal
{
    private List<JournalEntry> entries = new List<JournalEntry>();
    private static List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public List<JournalEntry> Entries { get => entries; }

    public static string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }

    public void AddEntry(JournalEntry entry)
    {
        entries.Add(entry);
    }

    public void LoadFromLines(string[] lines)
    {
        entries.Clear();
        foreach (var line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                DateTime date;
                if (DateTime.TryParse(parts[0], out date))
                {
                    JournalEntry entry = new JournalEntry(parts[1], parts[2], date);
                    entries.Add(entry);
                }
            }
        }
    }
}

class JournalEntry
{
    public string Prompt { get; }
    public string Response { get; }
    public DateTime Date { get; }

    public JournalEntry(string prompt, string response, DateTime date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }
}
