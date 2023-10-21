public class Reference
{
    public string VerseReference { get; private set; }
    public int Chapter { get; private set; }
    public int StartVerse { get; private set; }
    public int EndVerse { get; private set;

    public Reference(string verseReference)
    {
        VerseReference = verseReference;

        string[] parts = verseReference.Split(':');
        if (parts.Length == 2)
        {
            string[] verseParts = parts[1].Split('-');
            if (verseParts.Length == 1)
            {
                if (int.TryParse(verseParts[0], out int verseNumber))
                {
                    Chapter = int.Parse(parts[0]);
                    StartVerse = verseNumber;
                    EndVerse = verseNumber;
                }
            }
            else if (verseParts.Length == 2)
            {
                if (int.TryParse(verseParts[0], out int start) && int.TryParse(verseParts[1], out int end))
                {
                    Chapter = int.Parse(parts[0]);
                    StartVerse = start;
                    EndVerse = end;
                }
            }
        }
    }
}
