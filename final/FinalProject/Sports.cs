public class Sports : Exercise
{
    private string _sportType;

    public Sports(int duration, string sportType)
        : base("Sport - " + sportType, duration)
    {
        _sportType = sportType;
    }

    public string SportType => _sportType;

    public override double CalculateCaloriesBurned(User user)
    {
        double met = 7.5;
        double weightKg = user.Weight * 0.453592;
        return 0.0175 * met * weightKg * Duration;
    }

    public override string GetExerciseDetails(User user)
    {
        return $"{base.GetExerciseDetails(user)} | Sport: {SportType}";
    }
}
