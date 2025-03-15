class Checklist : Goal
{
    int count;
    int target;
    int bonus;

    public Checklist(string name, int points, int target, int bonus) : base(name, points)
    {
        this.target = target;
        this.bonus = bonus;
        count = 0;
    }

    public Checklist(string name, int points, int count, int target, int bonus) : base(name, points)
    {
        this.count = count;
        this.target = target;
        this.bonus = bonus;
    }

    public override int RecordProgress()
    {
        if (count < target)
        {
            count++;
            return count == target ? points + bonus : points;
        }
        return 0;
    }

    public override string GetStatus()
    {
        return (count >= target ? "[X] " : "[ ] ") + name + " (Completed " + count + "/" + target + " times)";
    }

    public override string Serialize()
    {
        return "Checklist|" + name + "|" + points + "|" + count + "|" + target + "|" + bonus;
    }
}
