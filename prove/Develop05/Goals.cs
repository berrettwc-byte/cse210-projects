class Goals
{
    private List<BaseGoal> _goals;
    private string _fileName;
    private int _totalScore;

    public Goals()
    {
        _goals = new List<BaseGoal>();
        _fileName = "goals.txt";
        _totalScore = 0;
    }

    public void AddGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();
        Console.Clear();

        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal());
                break;
            case "2":
                _goals.Add(new EternalGoal());
                break;
            case "3":
                _goals.Add(new CheckListGoal());
                break;
            default:
                Console.WriteLine("Invalid choice, no goal was created.");
                return;
        }
        Console.WriteLine("Goal created!");
    }

    public void LoadGoals()
    {
        ObtainFileName("What is the filename for the goal file? ");

        if (!File.Exists(_fileName))
        {
            Console.WriteLine("That file does not exist.");
            return;
        }

        List<BaseGoal> loaded = new List<BaseGoal>();
        int score = 0;

        string[] lines = File.ReadAllLines(_fileName);

        score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            if (lines[i].Trim() == "")
            {
                continue;
            }

            string[] p = lines[i].Split('|');
            string type = p[0];
            string name = p[1];
            string description = p[2];
            int points = int.Parse(p[3]);
            bool status = bool.Parse(p[4]);

            if (type == "SimpleGoal")
            {
                loaded.Add(new SimpleGoal(name, description, points, status));
            }
            else if (type == "EternalGoal")
            {
                int completions = int.Parse(p[5]);
                loaded.Add(new EternalGoal(name, description, points, status, completions));
            }
            else if (type == "CheckListGoal")
            {
                int completions = int.Parse(p[5]);
                int max = int.Parse(p[6]);
                int bonus = int.Parse(p[7]);
                loaded.Add(new CheckListGoal(name, description, points, status, completions, max, bonus));
            }
        }

        _goals = loaded;
        _totalScore = score;
        Console.WriteLine($"Loaded {_goals.Count} goals.");
    }

    public void SaveGoals()
    {
        ObtainFileName("What is the filename for the goal file? ");

        using (StreamWriter writer = new StreamWriter(_fileName))
        {
            writer.WriteLine(_totalScore);
            foreach (BaseGoal goal in _goals)
            {
                writer.WriteLine(goal.GetFileSystemString());
            }
        }
        Console.WriteLine("Goals saved.");
    }

    public void DisplayGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You have no goals yet.");
            return;
        }

        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetConsoleString()}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"You have {_totalScore} points.");
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You have no goals yet.");
            return;
        }

        DisplayGoals();
        Console.Write("Which goal did you accomplish? ");

        int number;
        if (!int.TryParse(Console.ReadLine(), out number) || number < 1 || number > _goals.Count)
        {
            Console.WriteLine("Invalid goal number.");
            return;
        }

        int earned = _goals[number - 1].RecordEvent();
        _totalScore += earned;

        if (earned == 0)
        {
            Console.WriteLine("That goal is already complete, so no points were earned.");
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {earned} points!");
        }
        DisplayScore();
    }

    public void ObtainFileName(string prompt)
    {
        Console.Write($"{prompt}(current: {_fileName}) ");
        string input = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(input))
        {
            _fileName = input.Trim();
        }
    }
}