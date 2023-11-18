using System;
using System.IO;
using System.Collections.Generic;
//using System.Linq;
using System.IO.Enumeration;
using System.Xml.Linq;
public class Game
{
 public string Name { get; set; }
  public string Type { get; set; }
   public int Score { get; set; }
  public bool Completed { get; set; }
  List<Goal> _goals = new List<Goal>();

  private int _points;

  public Game()
  {
    _points = 0;
  }

  public int getPoints()
  {
    return _points;
  }

  public void AddPoints(int points)
  {
    _points += points;
  }

  internal void Create()//(string name, string type)
    {
        //Name = name;
        //Type = type;
        //Completed = false;
        
    }
    public void MarkAsCompleted()
    {
        Completed = true;
    }

internal void Save()
    //public void SaveUser()
    //static internal Save( string fileName)
    
    {
        string fileName = "mytxt";
        using (StreamWriter writer = new StreamWriter(fileName));
        //Console.WriteLine($"{Game.Name},{Game.Goal},{Game.Score}");
    } 

    internal void Load()
    {
        string fileName = "mytxt";
        using (StreamReader reader = new StreamReader(fileName));
        //string line = reader.ReadLine();
        //string[] values = line.Split(',');
         //Goal goal = new Goal(values[0], int.Parse(values[0]), int.Parse(values[2]));

            
           Console.WriteLine(fileName);
    }
    internal void Progress()
    {
        
    }
    internal void List()
    {
        _goals = new List<Goal>();
    }
    public void AddGoal(Goal goal) => Goal.Add(goal);
     public void Display()
    {
        
        Console.WriteLine("List of goals:");

        
        //foreach (Goal goal in Goal)
        {
           // goal.Display();
        }
    }

}