public class Swimming : Exercise
{
    private string _strokeType;
    private double _laps;

    public Swimming(int duration, string strokeType, double laps)
        : base("Swimming", duration)
    {
        _strokeType = strokeType;
        _laps = laps;
    }

    public string StrokeType => _strokeType;
    public double Laps => _laps;

    public override double CalculateCaloriesBurned(User user)
    {
        double met = 8.0;
        double weightKg = user.Weight * 0.453592;
        return 0.0175 * met * weightKg * Duration;
    }

    public override string GetExerciseDetails(User user)
    {
        return $"{base.GetExerciseDetails(user)} | Stroke: {StrokeType}, Laps: {Laps}";
    }
}
