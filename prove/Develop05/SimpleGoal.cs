class SimpleGoal : BaseGoal
{
    public SimpleGoal() : base()
    {
        SetGoalType("SimpleGoal");
    }

    public SimpleGoal(string name, string description, int points, bool status) : base(name, description, points)
    {
        SetGoalType("SimpleGoal");
        if (status)
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

        MarkComplete();
        return GetPoints();
    }
}