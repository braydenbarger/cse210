class Entry
{
    private string _date;
    private int _promptId;
    private string _response;
    private string _mood;

    public Entry(string date, int promptId, string response, string mood)
    {
        _date = date;
        _promptId = promptId;
        _response = response;
        _mood = mood;
    }

    public void Display()
    {
        Console.WriteLine($"[{_date}] Prompt {_promptId}: {_response} (Mood: {_mood})");
    }

    public override string ToString()
    {
        return $"{_date}|{_promptId}|{_response}|{_mood}";
    }
}