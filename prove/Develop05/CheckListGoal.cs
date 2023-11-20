public class ChecklistGoal : Goal
{
    private int _goalComplet;
    private int _goalBonusPoints;
    private int _progress;
    public ChecklistGoal(string _goalName, string _goalDescription, int progress, int goalComplet, int goalBonus, bool _completed, int _goalValueInPoints, int _earnedPoints) : base(_goalName, _goalDescription, _goalValueInPoints, _completed, _earnedPoints)
    {
        _goalComplet = goalComplet;
        _goalBonusPoints = goalBonus;
        _progress = progress;
    }
    public void SetProgress()
    {
        _progress++;
    }
    public int GetProgress()
    {
        return _progress;
    }
    public void SetgoalComplet(int goal)
    {
        _goalComplet = goal;
    }
    public int GetgoalComplet()
    {
        return _goalComplet;
    }
    public void SetBonus(int goal)
    {
        _goalBonusPoints = goal;
    }
    public int GetBonus()
    {
        return _goalBonusPoints;
    }
    public ChecklistGoal()
    {
    }
    public override void CreateGoal()
    {
        Console.WriteLine("What is the name of your goal? ");
        SetGoalName(Console.ReadLine());
        Console.WriteLine("What is the short description of it? ");
        SetDescription(Console.ReadLine());
        Console.WriteLine("How many points do you want to set for this goal? ");
        SetgoalPoints(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        SetgoalComplet(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("What is the bonus for completing it many times?");
        SetBonus(Convert.ToInt32(Console.ReadLine()));
    }
    public override void RecordEvent()
    {
        SetProgress();
        SetEarnedPoints(GetgoalPoints());

        if (GetProgress() == GetgoalComplet())
        {
            SetCompleted(true);
            SetEarnedPoints(GetBonus());
        }

    }

    public override string PrintIsComplete()
    {
        if (GetCompleted())
        {
            return "[X]";
        }
        else
        {
            return "[ ]";
        }
    }

}