public class Comment
{
    private string _commentName;
    private string _commentText;
    public void SetComment2(string commentUser, string comment)
    {
        _commentName = commentUser;
        _commentText = comment;
    }
    public void DisplayComments()
    {
        Console.WriteLine($"{_commentName}: {_commentText}");
    }
}
