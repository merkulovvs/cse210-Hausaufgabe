using System;

public class Word
{
    private string _text;
    private bool _isHidden;
    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        for(int i = 0; i<_text.Length; i++)
        {
           
           

        }
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _text;
    }
}