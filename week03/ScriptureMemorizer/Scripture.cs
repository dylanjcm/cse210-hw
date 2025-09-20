using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private static Random rand = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                     .Select(word => new Word(word))
                     .ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        int count = 0;
        var availableIndexes = _words
            .Select((w, i) => new { Word = w, Index = i })
            .Where(x => !x.Word.IsHidden())
            .Select(x => x.Index)
            .ToList();

        while (count < numberToHide && availableIndexes.Count > 0)
        {
            int randomIdx = rand.Next(availableIndexes.Count);
            int wordIdx = availableIndexes[randomIdx];
            _words[wordIdx].Hide();
            availableIndexes.RemoveAt(randomIdx);
            count++;
        }
    }

    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()} - {string.Join(" ", _words.Select(w => w.GetDisplayText()))}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}
