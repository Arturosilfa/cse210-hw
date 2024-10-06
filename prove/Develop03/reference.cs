class Reference
{
    private string book;
    private int chapter;
    private int? startVerse;
    private int? endVerse;

    public Reference(string book, int chapter, int verse)
    {
        this.book = book;
        this.chapter = chapter;
        this.startVerse = verse;
        this.endVerse = null;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        this.book = book;
        this.chapter = chapter;
        this.startVerse = startVerse;
        this.endVerse = endVerse;
    }

    public string GetReference()
    {
        if (endVerse == null)
            return $"{book} {chapter}:{startVerse}";
        else
            return $"{book} {chapter}:{startVerse}-{endVerse}";
    }
}
