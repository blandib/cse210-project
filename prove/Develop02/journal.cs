using System;
public class Journal
{
    public string _question;
    public string _question1;
    public string _question2;
    public string _question3;
    public string _question4;
    public void Display()
    {
        Console.WriteLine($"{_question}({_question1}){_question2}{_question3}-{_question4}");
    }

}