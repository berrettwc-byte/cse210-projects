class CheckListGoal : BaseGoal
{
    private int _numberOfCompletions;
    private int _maxGoals;
    private int _bonusPoints;

    public CheckListGoal() : base()
    {
        SetGoalType("CheckListGoal");
        _numberOfCompletions = 0;
        ObtainMaxGoal();
        ObtainBonusPoints();
    }

    public CheckListGoal(string name, string description, int points, bool status, int completions, int max, int bonus) : base(name, description, points)
    {
        SetGoalType("CheckListGoal");
        _numberOfCompletions = completions;
        _maxGoals = max;
        _bonusPoints = bonus;
        if (status || _numberOfCompletions >= _maxGoals)
        {
            MarkComplete();
        }
    }

    public override int RecordEvent()
    {
        if (IsComplete())
        {
            return 0;
        }

        _numberOfCompletions++;
        int earned = GetPoints();

        if (_numberOfCompletions >= _maxGoals)
        {
            MarkComplete();
            earned += _bonusPoints;
        }

        return earned;
    }

    public override string GetConsoleString()
    {
        return base.GetConsoleString() + $" -- Completed {_numberOfCompletions}/{_maxGoals} times";
    }

    public override string GetFileSystemString()
    {
        return base.GetFileSystemString() + $"|{_numberOfCompletions}|{_maxGoals}|{_bonusPoints}";
    }

    private void ObtainMaxGoal()
    {
        Console.WriteLine("How many times will you do this goal: ");
        _maxGoals = int.Parse(Console.ReadLine());
    }

    private void ObtainBonusPoints()
    {
        Console.WriteLine("How many bonus points is this goal on completion?");
        _bonusPoints = int.Parse(Console.ReadLine());
    }
}
