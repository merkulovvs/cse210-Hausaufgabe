using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    private List<int> unusedIndexes = new List<int>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(" ");
        foreach(var word in words)
        {
            Word wordObj = new Word(word);
            _words.Add(wordObj);
        }

        for(int i=0; i < _words.Count; i++)
        {
            unusedIndexes.Add(i);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        //int numberHidden = 0;
        //while(numberToHide != numberHidden)
        //{
        //    Random rand = new Random();
        //    int index = rand.Next(_words.Count);
        //    if(_words[index].IsHidden() != true)
        //    {
        //        _words[index].Hide();
        //        numberHidden += 1;
        //    }
        //}

                                                                        

         for(int i = 0; i < numberToHide && unusedIndexes.Count > 0; i++)
         { 
       
           Random rand = new Random();
           int unusedListIndex = rand.Next(unusedIndexes.Count);
           int wordIndex = unusedIndexes[unusedListIndex];
           unusedIndexes.RemoveAt(unusedListIndex);
           _words[wordIndex].Hide();
    
          }
        //while(numberToHide > 0)
        //{   
        //    foreach(Word word in _words)
        //    {
        //        if(word.IsHidden() != true)
        //        {
        //           int index = rand.Next(_words.Count);
        //           _words[index].Hide();
        //
        //           numberToHide -= 1;     
        //        }
        //    }  
        //    
        //}

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
        
        return $"{_reference.GetDisplayText()} {scripture}";
    }
    
    public bool IsCompletelyHidden()
    {   
        int numOfHiddenWords = 0;
        foreach(Word word in _words)
        {
            if(word.IsHidden() == true)
            {
                numOfHiddenWords += 1;
            }
        }

        if(_words.Count == numOfHiddenWords)
        {
            return false;
        }
        else
        {
            return true;
        }
        
    }
}