public class Cycling : Exercise
{
    private double _distance;

    public Cycling(int duration, double distance)
        : base("Cycling", duration)
    {
        _distance = distance;
    }

    public double Distance => _distance;

    public override double CalculateCaloriesBurned(User user)
    {
        double met = 7.5;
        double weightKg = user.Weight * 0.453592;
        return 0.0175 * met * weightKg * Duration;
    }

    public override string GetExerciseDetails(User user)
    {
        return $"{base.GetExerciseDetails(user)} | Distance: {Distance} mi";
    }
}
