class Breathing : Activity
{
    public Breathing()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by guiding you through deep breathing exercises.";
    }

    public override void StartActivity()
    {
        base.StartActivity();
        Console.WriteLine(_description);
        ShowAnimation(3);

        for (int i = 0; i < _duration / 6; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowAnimation(3);
            Console.WriteLine("Breathe out...");
            ShowAnimation(3);
        }

        Console.WriteLine($"Good job! You completed the {_name} activity for {_duration} seconds.");
        ShowAnimation(3);
    }
}