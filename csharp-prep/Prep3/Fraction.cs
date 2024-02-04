using System;
using System.Globalization;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string topNumberStr = _top.ToString();
        string bottomNumberStr = _bottom.ToString();

        return $"{topNumberStr}/{bottomNumberStr}";
    }

    public double GetDecimalValue()
    {
        return _top / Convert.ToDouble(_bottom);
    }
}