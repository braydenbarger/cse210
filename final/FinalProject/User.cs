public class User
{
    private string _name;
    private int _age;
    private double _weight;
    private double _height;
    private List<Exercise> _workoutHistory = new List<Exercise>();

    public User(string name, int age, double weight, double height)
    {
        _name = name;
        _age = age;
        _weight = weight;
        _height = height;
    }

    public string Name => _name;
    public int Age => _age;
    public double Weight => _weight;
    public double Height => _height;
    public List<Exercise> WorkoutHistory => _workoutHistory;

    public void UpdateInfo(string name, int age, double weight, double height)
    {
        _name = name;
        _age = age;
        _weight = weight;
        _height = height;
    }

    public void AddWorkout(Exercise exercise)
    {
        _workoutHistory.Add(exercise);
    }

    public void DisplayWorkoutHistory()
    {
        foreach (var exercise in _workoutHistory)
        {
            Console.WriteLine($"{exercise.Date:g} - {exercise.GetExerciseDetails(this)}");
        }

        Console.WriteLine($"Total Workouts: {_workoutHistory.Count}");
    }

    public void DisplayDailyStats()
    {
        var today = DateTime.Today;
        var todayWorkouts = _workoutHistory.Where(e => e.Date.Date == today).ToList();

        double totalCalories = todayWorkouts.Sum(e => e.CalculateCaloriesBurned(this));
        int workoutCount = todayWorkouts.Count;

        Console.WriteLine($"Daily Stats for {today:d}:");
        Console.WriteLine($"Total Exercises: {workoutCount}");
        Console.WriteLine($"Total Calories Burned: {totalCalories:0.0}");
    }
}
