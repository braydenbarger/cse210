class Program
{
    static void Main()
    {
        User user = new User("Brayden", 21, 185);

        user.AddWorkout(new Running(duration: 30, intensity: 2.0, distance: 3.5));
        user.AddWorkout(new Cycling(duration: 45, intensity: 1.5, distance: 10, terrainType: "flat"));
        user.AddWorkout(new WeightLifting(duration: 40, intensity: 2.5, sets: 4, reps: 10, weight: 135));
        user.AddWorkout(new Swimming(duration: 20, intensity: 2.0, strokeType: "freestyle", laps: 10));
        user.AddWorkout(new Sports(duration: 60, intensity: 2.0, sportType: "Basketball"));

        Console.WriteLine("==== Workout History ====");
        user.DisplayWorkoutHistory();
    }
}
