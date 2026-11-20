class EternalGoal : BaseGoal
{
    private int _numberOfCompletions;

    public EternalGoal() : base()
    {
        SetGoalType("EternalGoal");
        _numberOfCompletions = 0;
    }

    public EternalGoal(string name, string description, int points, bool status, int completions) : base(name, description, points)
    {
        SetGoalType("EternalGoal");
        _numberOfCompletions = completions;
    }

    public override int RecordEvent()
    {
        _numberOfCompletions++;
        return GetPoints();
    }

    public override string GetConsoleString()
    {
        return base.GetConsoleString() + $", Recorded {_numberOfCompletions} times";
    }

    public override string GetFileSystemString()
    {
        return base.GetFileSystemString() + $"|{_numberOfCompletions}";
    }
}
