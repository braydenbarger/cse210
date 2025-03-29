public abstract class Exercise
{
    private string _name;
    private int _duration;
    private double _intensity;

    public Exercise(string name, int duration, double intensity)
    {
        _name = name;
        _duration = duration;
        _intensity = intensity;
    }

    public string Name => _name;
    public int Duration => _duration;
    public double Intensity => _intensity;

    public abstract double CalculateCaloriesBurned();

    public virtual string GetExerciseDetails()
    {
        return $"{_name} - Duration: {_duration} min - Intensity: {Intensity}";
    }
}
