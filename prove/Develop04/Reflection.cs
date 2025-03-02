class Reflection : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What did you learn about yourself?",
        "How can you apply this lesson in the future?"
    };

    public Reflection()
    {
        _name = "Reflection";
        _description = "This activity will help you reflect on times in your life when you showed strength and resilience.";
    }

    public override void StartActivity()
    {
        base.StartActivity();

        Random rand = new Random();
        Console.WriteLine($"Prompt: {_prompts[rand.Next(_prompts.Count)]}");
        ShowAnimation(3);

        int elapsedTime = 0;
        while (elapsedTime < _duration)
        {
            Console.WriteLine($"Question: {_questions[rand.Next(_questions.Count)]}");
            ShowAnimation(5);
            elapsedTime += 5;
        }

        Console.WriteLine($"Well done! You completed the {_name} activity for {_duration} seconds.");
        ShowAnimation(3);
    }
}
