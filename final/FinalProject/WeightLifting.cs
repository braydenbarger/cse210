public class WeightLifting : Exercise
{
    private int _sets;
    private int _reps;
    private double _weight;

    public WeightLifting(int duration, double intensity, int sets, int reps, double weight)
    {
        _sets = sets;
        _reps = reps;
        _weight = weight;
    }

    public override double CalculateCaloriesBurned()
    {
        
    }

    public override string GetExerciseDetails()
    {

    }
}
