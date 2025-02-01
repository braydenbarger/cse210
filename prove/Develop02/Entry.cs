class Entry
{
    private string _date;
    private int _promptId;
    private string _response;

    public Entry(string date, int promptId, string response)
    {
        _date = date;
        _promptId = promptId;
        _response = response;
    }

    public void Display()
    {
        Console.WriteLine($"[{_date}] Prompt {_promptId}: {_response}");
    }

    public override string ToString()
    {
        return $"{_date}|{_promptId}|{_response}";
    }
}