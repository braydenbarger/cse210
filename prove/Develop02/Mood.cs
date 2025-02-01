class MoodTracker
{
    private static List<string> moods = new List<string>
    {
        "Happy",
        "Sad",
        "Excited",
        "Stressed",
        "Calm",
        "Angry"
    };

    public static string GetMood()
    {
        Console.WriteLine("Select your mood:");
        for (int i = 0; i < moods.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {moods[i]}");
        }
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > moods.Count)
        {
            Console.WriteLine("Invalid choice. Please select a valid mood.");
        }
        return moods[choice - 1];
    }
}