using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(" ");
        foreach(var word in words)
        {
            Word wordObj = new Word(word);
            _words.Add(wordObj);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        
    }

    public string GetDisplayText()
    {

        return $"{_reference.GetDisplayTextOneVerse()}";
    }

    public bool IsCompletelyHidden()
    {   
        return false;
    }
}