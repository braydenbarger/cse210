class Scripture
{
    private List<Word> words;
    private Random random = new Random();
    private Reference reference;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void Display()
    {
        Console.WriteLine(reference.ToString());
        Console.WriteLine(string.Join(" ", words));
    }

    public void HideRandomWords(int count)
    {
        List<Word> visibleWords = words.Where(w => !w.IsHidden()).ToList();
        for (int i = 0; i < count && visibleWords.Any(); i++)
        {
            visibleWords[random.Next(visibleWords.Count)].Hide();
        }
    }

    public bool AllWordsHidden()
    {
        return words.All(w => w.IsHidden());
    }
}
