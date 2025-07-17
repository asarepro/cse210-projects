public class Reference
{
    public string Book { get; private set; }
    public int Chapter { get; private set; }
    public int VerseStart { get; private set; }
    public int? VerseEnd { get; private set; }

    public Reference(string book, int chapter, int verseStart)
    {
        Book = book;
        Chapter = chapter;
        VerseStart = verseStart;
        VerseEnd = null;
    }

    public Reference(string reference)
    {
        var parts = reference.Split(' ');
        Book = parts[0];
        var verseParts = parts[1].Split(':');
        Chapter = int.Parse(verseParts[0]);

        if (verseParts[1].Contains("-"))
        {
            var range = verseParts[1].Split('-');
            VerseStart = int.Parse(range[0]);
            VerseEnd = int.Parse(range[1]);
        }
        else
        {
            VerseStart = int.Parse(verseParts[1]);
            VerseEnd = null;
        }
    }

    public override string ToString()
    {
        return VerseEnd.HasValue
            ? $"{Book} {Chapter}:{VerseStart}-{VerseEnd}"
            : $"{Book} {Chapter}:{VerseStart}";
    }
}