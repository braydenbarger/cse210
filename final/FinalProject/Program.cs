class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Exercise Tracker!");

        User user = GetUserInfo();

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Adjust User Info");
            Console.WriteLine("2. Record Workout");
            Console.WriteLine("3. View Workout Log");
            Console.WriteLine("4. View Daily Stats");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    user = GetUserInfo();
                    break;

                case "2":
                    RecordWorkout(user);
                    break;

                case "3":
                    Console.WriteLine($" Workout Log for {user.Name}:");
                    user.DisplayWorkoutHistory();
                    break;

                case "4":
                    user.DisplayDailyStats();
                    break;

                case "5":
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    static User GetUserInfo()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Enter your weight (lbs): ");
        double weight = double.Parse(Console.ReadLine());
        Console.Write("Enter your height (inches): ");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("Info saved.");
        return new User(name, age, weight, height);
    }

    static void RecordWorkout(User user)
    {
        Console.WriteLine("Workout Types:");
        Console.WriteLine("1. Running");
        Console.WriteLine("2. Cycling");
        Console.WriteLine("3. Weight Lifting");
        Console.WriteLine("4. Swimming");
        Console.WriteLine("5. Sports");
        Console.Write("Choose a workout type: ");
        string workoutType = Console.ReadLine();

        Console.Write("Duration (minutes): ");
        int duration = int.Parse(Console.ReadLine());

        switch (workoutType)
        {
            case "1":
                Console.Write("Distance (miles): ");
                double runDist = double.Parse(Console.ReadLine());
                user.AddWorkout(new Running(duration, runDist));
                break;

            case "2":
                Console.Write("Distance (miles): ");
                double cycleDist = double.Parse(Console.ReadLine());
                user.AddWorkout(new Cycling(duration, cycleDist));
                break;

            case "3":
                Console.Write("Type of lift (e.g., Bench Press, Squat): ");
                string liftType = Console.ReadLine();
                Console.Write("Sets: ");
                int sets = int.Parse(Console.ReadLine());
                Console.Write("Reps per set: ");
                int reps = int.Parse(Console.ReadLine());
                Console.Write("Weight (lbs): ");
                double liftWeight = double.Parse(Console.ReadLine());
                user.AddWorkout(new WeightLifting(duration, sets, reps, liftWeight, liftType));
                break;

            case "4":
                Console.Write("Stroke Type: ");
                string stroke = Console.ReadLine();
                Console.Write("Laps: ");
                double laps = double.Parse(Console.ReadLine());
                user.AddWorkout(new Swimming(duration, stroke, laps));
                break;

            case "5":
                Console.Write("Sport Type (Basketball, Soccer, etc.): ");
                string sport = Console.ReadLine();
                user.AddWorkout(new Sports(duration, sport));
                break;

            default:
                Console.WriteLine("Invalid workout type.");
                break;
        }

        Console.WriteLine("Workout recorded.");
    }
}
