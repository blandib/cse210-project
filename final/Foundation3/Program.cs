using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();

        Lecture Ben = new Lecture("Ben Mbaya", 800, " Digital Elite!", " is a 3 day long get together for professionals on topics related to digital growth, traffic, and conversions.", "1/5/2023", "9:00 AM", "0B Pullford Ln Bedford Park, Germiston, JOHANNESBURG, South Africa");
        events.Add(Ben);

        OutdoorGathering bob = new OutdoorGathering("Photoville", "is a photography exhibit and festival (complete with a beer garden, outdoor performances, and a variety of workshops) is housed in a series of traveling storage pods.", "07/04/2023", "3:00 PM", "5 Wolseley St Woodmead, Sandton, Johannesburg, South Africa");
        events.Add(bob);

        Reception wedding = new Reception("Eve & Ben Wedding", "Join us for the Wedding celebration of Eve & Ben", "02/14/2024", "18:30 PM", "Q8J8+JVX, Zanzibar, Tunguu, Tanzania");
        events.Add(wedding);

        foreach (Event plan in events)
        {
            plan.FullDetails();
        }
    }
}