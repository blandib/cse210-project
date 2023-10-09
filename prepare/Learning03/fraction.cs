using System;
public class Fraction
{
    // Fields
    private int _top;
    private int _botton;
    // Default constructor
    public Fraction()
    {
        // Initialize the number to 1/1
        _top = 1;
        _botton = 1;
    }
    public Fraction( int nunerator)
    {    _top = nunerator;
        _botton = 1;
    }
    public Fraction(int top, int botton)
    {
      _top = top;
      _botton = botton;
    }
    public string GetFractionString()
    {
        string txt = $"{_top}/{_botton}";
        return txt;
    }
    public double GetDecimalValue()
    {
        return (double) _top / (double) _botton;
    }
}