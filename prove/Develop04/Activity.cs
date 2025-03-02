class Activity
{
    public string _name;
    public string _description;
    public int _duration;
    
    private static Dictionary<string, int> _customDurations = new Dictionary<string, int>
    {
        { "Breathing", 30 },
        { "Reflection", 45 },
        { "Listing", 60 }
    };

    protected void SetDuration()
    {
        _duration = _customDurations[_name];
    }

    public static void SetCustomDurations()
    {
        foreach (var key in _customDurations.Keys.ToList())
        {
            Console.Write($"Enter default duration for {key} activity (seconds): ");
            if (int.TryParse(Console.ReadLine(), out int duration) && duration > 0)
            {
                _customDurations[key] = duration;
            }
            else
            {
                Console.WriteLine("Invalid input. Keeping previous default.");
            }
        }

        Console.WriteLine("Default durations updated! Press Enter to return to the menu.");
        Console.ReadLine();
    }

    protected void ShowAnimation(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write($"\r{spinner[i % spinner.Length]}");
            Thread.Sleep(250);
        }
        Console.WriteLine();
    }

    public virtual void StartActivity()
    {
        SetDuration();
        Console.WriteLine($"Starting {_name} activity for {_duration} seconds...");
        ShowAnimation(3);
    }
}