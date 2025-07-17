using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void HideRandomWords(int count)
    {
        var unhiddenWords = _words.Where(w => !w.IsHidden).ToList();
        var random = new Random();

        for (int i = 0; i < count && unhiddenWords.Count > 0; i++)
        {
            int index = random.Next(unhiddenWords.Count);
            unhiddenWords[index].Hide();
            unhiddenWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string text = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        int hiddenCount = _words.Count(w => w.IsHidden);
        int total = _words.Count;
        double percent = (double)hiddenCount / total * 100;

        return $"{_reference}\n{text}\n\nProgress: {percent:F1}% hidden";
    }

    public bool AllWordsHidden()
    {
        return _words.All(w => w.IsHidden);
    }
}