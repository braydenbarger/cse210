class Program
{
    static List<Goal> goals = new List<Goal>();
    static int score = 0;

    static void Main()
    {
        LoadGoals();
        while (true)
        {
            Console.WriteLine("Eternal Quest Program");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Goal Progress");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save and Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            if (choice == "1") CreateGoal();
            else if (choice == "2") RecordGoal();
            else if (choice == "3") DisplayGoals();
            else if (choice == "4") Console.WriteLine("Current Score: " + score);
            else if (choice == "5")
            {
                SaveGoals();
                break;
            }
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("Select Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter choice: ");
        string type = Console.ReadLine();

        Console.Write("Enter Goal Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            goals.Add(new Simple(name, points));
        }
        else if (type == "2")
        {
            goals.Add(new Eternal(name, points));
        }
        else if (type == "3")
        {
            Console.Write("Enter Target Count: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Enter Bonus Points: ");
            int bonus = int.Parse(Console.ReadLine());
            goals.Add(new Checklist(name, points, target, bonus));
        }
    }

    static void RecordGoal()
    {
        DisplayGoals();
        Console.Write("Enter goal number to record progress: ");
        int index = int.Parse(Console.ReadLine()) - 1;
        if (index >= 0 && index < goals.Count)
        {
            score += goals[index].RecordProgress();
            Console.WriteLine("Progress recorded! New Score: " + score);
        }
    }

    static void DisplayGoals()
    {
        Console.WriteLine("Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + goals[i].GetStatus());
        }
    }

    static void SaveGoals()
    {
        using (StreamWriter file = new StreamWriter("goals.txt"))
        {
            file.WriteLine(score);
            foreach (Goal goal in goals)
            {
                file.WriteLine(goal.Serialize());
            }
        }
    }

    static void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            string[] lines = File.ReadAllLines("goals.txt");
            score = int.Parse(lines[0]);
            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split("|");
                if (parts[0] == "Simple") goals.Add(new Simple(parts[1], int.Parse(parts[2]), bool.Parse(parts[3])));
                else if (parts[0] == "Eternal") //Here is where eternal streaks are saved in program.cs mosr of the additional creativity reuirement is done in Eternal.cs
                    {
                        DateTime lastDate = DateTime.Parse(parts[4]);
                        goals.Add(new Eternal(parts[1], int.Parse(parts[2]), int.Parse(parts[3]), lastDate));
                    }
                else if (parts[0] == "Checklist") goals.Add(new Checklist(parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5])));
            }
        }
    }
}
