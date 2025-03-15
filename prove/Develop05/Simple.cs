class Simple : Goal
{
    bool isCompleted;

    public Simple(string name, int points) : base(name, points)
    {
        isCompleted = false;
    }

    public Simple(string name, int points, bool isCompleted) : base(name, points)
    {
        this.isCompleted = isCompleted;
    }

    public override int RecordProgress()
    {
        if (!isCompleted)
        {
            isCompleted = true;
            return points;
        }
        return 0;
    }

    public override string GetStatus()
    {
        return (isCompleted ? "[X] " : "[ ] ") + name;
    }

    public override string Serialize()
    {
        return "Simple|" + name + "|" + points + "|" + isCompleted;
    }
}
