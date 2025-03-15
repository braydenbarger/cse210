class Eternal : Goal
{
    int streak;
    DateTime lastCompletionDate;

    public Eternal(string name, int points) : base(name, points)
    {
        streak = 0;
        lastCompletionDate = DateTime.MinValue;
    }
    //Most of the streaks functionality are handeled from here down
    public Eternal(string name, int points, int streak, DateTime lastCompletionDate) : base(name, points)
    {
        this.streak = streak;
        this.lastCompletionDate = lastCompletionDate;
    }

    public override int RecordProgress()
    {
        DateTime today = DateTime.Today;

        if (lastCompletionDate == today)
        {
            return 0;
        }

        if (lastCompletionDate == today.AddDays(-1))
        {
            streak++;
        }
        else
        {
            streak = 1;
        }

        lastCompletionDate = today;

        return points;
    }

    public override string GetStatus()
    {
        return "[∞] " + name + " (Streak: " + streak + " days)";
    }

    public override string Serialize()
    {
        return "Eternal|" + name + "|" + points + "|" + streak + "|" + lastCompletionDate.ToString("yyyy-MM-dd");
    }
}
