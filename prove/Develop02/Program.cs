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
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            if (choice == 1)
            {
                int promptId = randomGenerator.Next(1, 6);
                Console.WriteLine(Prompt.GetPrompt(promptId));
                string response = Console.ReadLine();
                string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                journal.AddEntry(new Entry(date, promptId, response));
            }
            else if (choice == 2)
            {
                journal.Display();
            }
            else if (choice == 3)
            {
                journal.LoadJournal(filename);
            }
            else if (choice == 4)
            {
                journal.SaveJournal(filename);
            }
            else if (choice == 5)
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid option.");
            }
        }
    }
}
