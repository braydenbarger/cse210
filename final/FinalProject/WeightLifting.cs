public class WeightLifting : Exercise
{
    private int _sets;
    private int _reps;
    private double _weight;
    private string _liftType;

    public WeightLifting(int duration, int sets, int reps, double weight, string liftType)
        : base("Weight Lifting", duration)
    {
        _sets = sets;
        _reps = reps;
        _weight = weight;
        _liftType = liftType;
    }

    public int Sets => _sets;
    public int Reps => _reps;
    public double Weight => _weight;
    public string LiftType => _liftType;

    public override double CalculateCaloriesBurned(User user)
    {
        double met = 6.0;
        double weightKg = user.Weight * 0.453592;
        return 0.0175 * met * weightKg * Duration;
    }

    public override string GetExerciseDetails(User user)
    {
        return $"{base.GetExerciseDetails(user)} | Lift: {LiftType}, Sets: {Sets}, Reps: {Reps}, Weight: {Weight} lbs";
    }
}
