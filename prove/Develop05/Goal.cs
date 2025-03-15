abstract class Goal
{
    protected string name;
    protected int points;

    protected Goal(string name, int points)
    {
        this.name = name;
        this.points = points;
    }

    public abstract int RecordProgress();
    public abstract string GetStatus();
    public abstract string Serialize();
}
