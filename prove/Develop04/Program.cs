class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            // My creative addition to the program
            Console.WriteLine("4. Set Default Durations");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");
            
            string choice = Console.ReadLine();
            Activity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new Breathing();
                    break;
                case "2":
                    activity = new Reflection();
                    break;
                case "3":
                    activity = new Listing();
                    break;
                case "4":
                    // My creative addition to the program
                    Activity.SetCustomDurations();
                    continue;
                case "5":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Press Enter to try again.");
                    Console.ReadLine();
                    continue;
            }

            activity.StartActivity();
        }
    }
}