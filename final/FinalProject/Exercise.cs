public abstract class Exercise
{
    private string _name;
    private int _duration;
    private DateTime _date;

    protected Exercise(string name, int duration)
    {
        _name = name;
        _duration = duration;
        _date = DateTime.Now;
    }

    public string Name => _name;
    public int Duration => _duration;
    public DateTime Date => _date;

    public abstract double CalculateCaloriesBurned(User user);

    public virtual string GetExerciseDetails(User user)
    {
        return $"{Name} | Duration: {Duration} min | Calories: {CalculateCaloriesBurned(user):0.0}";
    }
}
