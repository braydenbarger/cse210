class Reference
{
    private string book;
    private int chapter, startVerse, endVerse;

    public Reference(string book, int chapter, int startVerse, int endVerse = -1)
    {
        this.book = book;
        this.chapter = chapter;
        this.startVerse = startVerse;
        this.endVerse = endVerse == -1 ? startVerse : endVerse;
    }

    public override string ToString()
    {
        if (startVerse == endVerse)
        {
            return $"{book} {chapter}:{startVerse}";
        }
        else
        {
            return $"{book} {chapter}:{startVerse}-{endVerse}";
        }
    }
}

