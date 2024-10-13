public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Duration { get; set; } // Length in seconds
    private List<Comment> Comments { get; set; }

    public Video(string title, string author, int Duration)
    {
        Title = title;
        Author = author;
        Duration = Duration;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    public List<Comment> GetComments()
    {
        return Comments;
    }
}
