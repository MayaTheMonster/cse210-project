using System.ComponentModel;
using System.Net;
using System.Runtime.InteropServices;

public class Video
{
    private string _videoTitle;
    private string _videoAuthor;
    private int _videoTime;
    private List<Comment> _Comments = new List<Comment>();
    
    public int ReturnCommentAmmount()
    {
        int _commentAmmount = 0;
        foreach(Comment _comment in _Comments)
        {
            _commentAmmount+=1;
        }
        return _commentAmmount;
    }
    public void SetVideo(string videoTitle, string videoAuthor, int videoTime)
    {
    _videoTitle = videoTitle;
    _videoAuthor = videoAuthor;
    _videoTime = videoTime;
    }

    public void SetComment(string name, string text)
    {
        Comment _Setting = new Comment(); 
        _Setting.SetComment2(name, text);
        _Comments.Add(_Setting);
    }
    public void DisplayVideoThings(int ammount)
    {
        Console.WriteLine($" Author: {_videoAuthor} Title: {_videoTitle}\nTime(in seconds): {_videoTime} Number of comments: {ammount}");
        foreach(Comment _comment in _Comments)
        {
            _comment.DisplayComments();
        }
    }
}