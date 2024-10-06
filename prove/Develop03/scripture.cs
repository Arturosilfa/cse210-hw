class Scripture
{
    private List<Word> words;
    private Reference reference;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void Display()
    {
        Console.WriteLine(reference.GetReference());
        Console.WriteLine(string.Join(" ", words.Select(word => word.ToString())));
    }


    public void HideRandomWords()
    {
        Random rand = new Random();
        int wordsToHide = 3; 

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = rand.Next(words.Count);
            words[index].Hide();
        }
    }

    public bool AllWordsHidden()
    {
        return words.All(word => word.IsHidden());
    }
}
