class Word
{
    private string text;
    private bool isHidden;

    public Word(string text)
    {
        this.text = text;
        this.isHidden = false;
    }

    public void Hide()
    {
        this.isHidden = true;
    }

    public bool IsHidden()
    {
        return this.isHidden;
    }

    public override string ToString()
    {
        return isHidden ? "_____" : text;
    }
}

