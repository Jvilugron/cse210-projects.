using System;
using System.Collections.Generic;

public class Scripture
{
    public string Reference { get; private set; }
    public string Text { get; private set; }
    private List<string> hiddenWords;

    public Scripture(string reference, string text)
    {
        Reference = reference;
        Text = text;
        hiddenWords = new List<string>();
    }

    public void HideRandomWord()
    {
        if (hiddenWords.Count >= Text.Split(' ').Length)
        {
            Console.WriteLine("All words are already hidden. Press Enter to quit.");
            return;
        }

        string[] words = Text.Split(' ');
        Random random = new Random();
        int randomIndex;

        do
        {
            randomIndex = random.Next(words.Length);
        } while (hiddenWords.Contains(words[randomIndex]));

        hiddenWords.Add(words[randomIndex]);
        Console.Clear();
        DisplayScripture();
    }

    public void DisplayScripture()
    {
        Console.WriteLine($"Reference: {Reference}\n");
        foreach (string word in Text.Split(' '))
        {
            if (hiddenWords.Contains(word))
                Console.Write("_____ ");
            else
                Console.Write(word + " ");
        }
        Console.WriteLine("\n");
    }
}
