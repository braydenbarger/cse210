class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        Menu menu = new Menu();
        string filename = "journal.txt";
        Random randomGenerator = new Random();
        bool running = true;

        while (running)
        {
            menu.Display();
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    int promptId = randomGenerator.Next(1, 6);
                    Console.WriteLine(Prompt.GetPrompt(promptId));
                    string response = Console.ReadLine();
                    string mood = MoodTracker.GetMood();
                    string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                    journal.AddEntry(new Entry(date, promptId, response, mood));
                    break;
                case 2:
                    journal.Display();
                    break;
                case 3:
                    journal.LoadJournal(filename);
                    break;
                case 4:
                    journal.SaveJournal(filename);
                    break;
                case 5:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }
}