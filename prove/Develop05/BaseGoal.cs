abstract class BaseGoal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _status;
    private string _goalType;

    public BaseGoal()
    {
        SetName(); 
        SetDescription();
        SetPoints();
        _status = false;
        _goalType = "BaseGoal";
    }

    public BaseGoal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _status = false;
        _goalType = "BaseGoal";
    }

    private void SetName()
    {
        Console.WriteLine("What is the name of your goal: ");
        _name = Console.ReadLine();
    }

    private void SetDescription()
    {
        Console.WriteLine($"What is the description of {_name} goal: ");
        _description = Console.ReadLine();
    }

    private void SetPoints()
    {
        Console.WriteLine($"What are the points for {_name} goal: ");
        _points = int.Parse(Console.ReadLine());
    }

    protected void SetGoalType(string goalType)
    {
        _goalType = goalType;
    }

    protected int GetPoints()
    {
        return _points;
    }

    protected void MarkComplete()
    {
        _status = true;
    }

    public bool IsComplete()
    {
        return _status;
    }


    public virtual string GetConsoleString()
    {
        string box = _status ? "[X]" : "[ ]";
        return $"{box} Goal Name: {_name}, Description: {_description}, points: {_points}";
    }

    public virtual string GetFileSystemString()
    {
        return $"{_goalType}|{_name}|{_description}|{_points}|{_status}";
    }

    public abstract int RecordEvent();
}