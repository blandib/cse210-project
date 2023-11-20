public class Game
{
    //DisplayPoints()
    List<Goal> goals = new List<Goal>();
    public void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine($"You have {CalculateTotalPoints()} points");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("     1. Create New Goal");
            Console.WriteLine("     2. List Goals");
            Console.WriteLine("     3. Save Goals");
            Console.WriteLine("     4. Load Goals");
            Console.WriteLine("     5. Record Event");
            Console.WriteLine("     6. Quit");
            Console.WriteLine("Please select an option:");
            int ShowMenuChoice = Convert.ToInt32(Console.ReadLine());
            if (ShowMenuChoice == 1)
            {
                Console.Clear();
                Console.WriteLine("The types of goal are:");
                Console.WriteLine("     1. Simple Goal");
                Console.WriteLine("     2. Eternal Goal");
                Console.WriteLine("     3. Checklist Goal");
                Console.WriteLine("Please select an option:");
                int createGoalChoice = Convert.ToInt32(Console.ReadLine());
                if (createGoalChoice == 1)
                {
                    Console.Clear();
                    SimpleGoal simpleGoal = new SimpleGoal();
                    simpleGoal.CreateGoal();
                    goals.Add(simpleGoal);

                }
                else if (createGoalChoice == 2)
                {
                    Console.Clear();
                    EternalGoal eternalGoal = new EternalGoal();
                    eternalGoal.CreateGoal();
                    goals.Add(eternalGoal);
                }
                else if (createGoalChoice == 3)
                {
                    Console.Clear();
                    ChecklistGoal checklistGoal = new ChecklistGoal();
                    checklistGoal.CreateGoal();
                    goals.Add(checklistGoal);
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }
            }
            else if (ShowMenuChoice == 2)
            {
                Console.Clear();

                foreach (Goal goal in goals)
                {
                    if (goal is ChecklistGoal)
                    {
                        ChecklistGoal checklistGoal = (ChecklistGoal)goal;
                        Console.WriteLine($"{checklistGoal.PrintIsComplete()} {checklistGoal.GetGoalName()} ({checklistGoal.GetDescription()}) --- Currently completed: {checklistGoal.GetProgress()}/{checklistGoal.GetgoalComplet()} times");
                    }
                    else
                    {
                        Console.WriteLine($"{goal.PrintIsComplete()} {goal.GetGoalName()} ({goal.GetDescription()})");

                    }
                }
            }
            else if (ShowMenuChoice == 3)
            {
                this.WriteFile();

            }
            else if (ShowMenuChoice == 4)
            {
                this.LoadFile();
            }
            else if (ShowMenuChoice == 5)
            {
                Console.Clear();

                Console.WriteLine("These are you goals:");
                int index = 1;
                foreach (Goal goal in goals)
                {
                    Console.WriteLine(index + ". " + goal.GetGoalName());
                    index++;
                }
                Console.WriteLine("What goal have you completed?");
                int completedChoice = int.Parse(Console.ReadLine());
                if (completedChoice >= 1 && completedChoice <= goals.Count)
                {
                    Goal completedGoal = goals[completedChoice - 1];
                    completedGoal.RecordEvent();
                    Console.WriteLine("Good Job!");
                }
                else
                {
                    Console.WriteLine("Invalid goal choice.");
                }
            }

            else if (ShowMenuChoice == 6)
            {
                break;

            }
        }

    }

    public void WriteFile()
    {



        Console.WriteLine("What is the file name you would like to choose? Enter .txt at the end");
        string _fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            outputFile.WriteLine(CalculateTotalPoints());
            foreach (Goal goal in goals)
            {
                if (goal is ChecklistGoal)
                {
                    ChecklistGoal checklistGoal = (ChecklistGoal)goal;
                    outputFile.WriteLine($"{goal.GetType()}:|{checklistGoal.GetGoalName()}|{checklistGoal.GetDescription()}|{checklistGoal.GetgoalPoints()}|{checklistGoal.GetBonus()}/{checklistGoal.GetProgress()}|{checklistGoal.GetgoalComplet()}|{checklistGoal.GetCompleted()}|{checklistGoal.GetEarnedPoints()}");
                }
                else
                {
                    outputFile.WriteLine($"{goal.GetType()}:|{goal.GetGoalName()}|{goal.GetDescription()}|{goal.GetgoalPoints()}|{goal.GetCompleted()}|{goal.GetEarnedPoints()}");

                }
            }
        }
    }

    public void LoadFile()
    {
        Console.WriteLine("What is the goal filename to Load?");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        lines = lines.Skip(1).ToArray();

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            string name = parts[1];
            string desc = parts[2];
            int goalPoints = int.Parse(parts[3]);
            if (parts[4].Contains("/"))
            {
                string bonus = parts[4];
                string[] checklistParts = bonus.Split("/");
                bonus = checklistParts[0];
                int progress = int.Parse(checklistParts[1]);
                int bonusInt = int.Parse(bonus);
                int goal = int.Parse(checklistParts[1]);
                bool complete = bool.Parse(parts[6]);
                int earned = int.Parse(parts[7]);
                goals.Add(new ChecklistGoal(name, desc, progress, goal, bonusInt, complete, goalPoints, earned));

            }
            else
            {
                int earned = int.Parse(parts[5]);
                bool complete = bool.Parse(parts[4]);
                string goalType = parts[0];
                if (goalType == "SimpleGoal:")
                {
                    goals.Add(new SimpleGoal(name, desc, goalPoints, complete, earned));

                }
                else
                {
                    goals.Add(new EternalGoal(name, desc, goalPoints, complete, earned));

                }
            }




        }

    }




    public int CalculateTotalPoints()
    {
        int totalPoints = 0;
        foreach (Goal goal in goals)
        {
            totalPoints += goal.GetEarnedPoints();
        }
        return totalPoints;
    }



}