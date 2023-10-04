using System;
public class Journal
{
    public string _Write;
    public string _Display;
    public string _Laod;
    public string _Savs;
    public string _Quict;
    public void Display()
    {
        Console.WriteLine($"{_Write}({_Display}){_Laod}{_Save}-{_Quict}");
    }

}