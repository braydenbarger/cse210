class Listing : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };

    public Listing()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life.";
    }

    public override void StartActivity()
    {
        base.StartActivity();

        Random rand = new Random();
        Console.WriteLine($"Prompt: {_prompts[rand.Next(_prompts.Count)]}");
        ShowAnimation(3);

        Console.WriteLine("Start listing your answers:");
        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item: ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"You listed {count} items. Well done!");
        ShowAnimation(3);
    }
}
