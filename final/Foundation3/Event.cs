using System;

class Event
{
    protected string _eventTitle;
    protected string _description;
    
    protected string _date;
    protected string _time;
    protected Address _venuAddress;

    public Event(string aTitle, string aDescription, string aDate, string aTime, string aAddress)
    {
        _eventTitle = aTitle;
        _description = aDescription;
        _date = aDate;
        _time = aTime;
        List<string> parts = new List<string>(aAddress.Split(","));
        _venuAddress = new Address(parts[0], parts[1], parts[2], parts[3]);
        
        
    }

    public void StandardDetails()
    {   
        Console.WriteLine("\n---Standard Details---\n");
        Console.WriteLine($"Event: {_eventTitle}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_venuAddress.DisplayAddress()}");
        Console.WriteLine();
    }
    public virtual void FullDetails()
    {
        Console.WriteLine($"Event: {_eventTitle}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress:{_venuAddress.DisplayAddress()}");
        Console.WriteLine();
    }

    public string ShortDetails(Type aType)
    {
        return $"\n---Short Details---\n\nEvent Type: {aType}\nTitle: {_eventTitle}\nDescription: {_description}\n";
    }

    public string GetDate()
    {
        return _date;
    }
}
