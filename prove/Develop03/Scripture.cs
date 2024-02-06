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
       string scripture = "";
       for(int i = 0; i < _words.Count; i++)
       {
           if(i != _words.Count)
           {
            scripture += _words[i].GetDisplayText() + " ";
           }
           else
           {
            scripture += _words[i].GetDisplayText();
           }
           
       }
        
        return $"{_reference.GetDisplayTextOneVerse()} {scripture}";
    }
    
    //Checking contents of List _words.

    //public void GetDisplayVerse()
    //{
    //    //string[] scripture = new string[_words.Count];
    //    for (int i = 0; i < _words.Count; i++)
    //    {   
    //        //scripture[i] = _words[i].GetDisplayText();
    //        Console.Write($"{_words[i].GetDisplayText()} ");
    //    }
    //    //Console.WriteLine(scripture);
    //}

    public bool IsCompletelyHidden()
    {   
        return false;
    }
}