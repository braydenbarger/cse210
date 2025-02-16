class Program
{
    static void Main()
    {
        Console.Clear();
        Console.Write("Enter the number of words to hide each time: ");
        if (!int.TryParse(Console.ReadLine(), out int wordsToHide) || wordsToHide < 1)
        {
            wordsToHide = 2;
        }
        
        Reference reference = new Reference("1 Nephi", 4, 6);
        Scripture scripture = new Scripture(reference, "And I was led by the Spirit, not knowing beforehand the things which I should do.");
        
        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            scripture.Display();
            Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();
            
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(wordsToHide);
        }
    }
}