public class User
{
    private string _name;
    private int _age;
    private double _weight;
    private List<Exercise> _workoutHistory = new List<Exercise>();

    public User(string name, int age, double weight)
    {
        _name = name;
        _age = age;
        _weight = weight;
    }

    public void AddWorkout(Exercise exercise)
    {
    }

    public double GetTotalCaloriesBurned()
    {

    }

    public void DisplayWorkoutHistory()
    {

    }
}
