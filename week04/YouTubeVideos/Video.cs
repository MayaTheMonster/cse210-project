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
        int commentAmmount = 0;
        foreach(Comment comment in _Comments)
        {
            commentAmmount+=1;
        }
        return commentAmmount;
    }
    public void SetVideo(string videoTitle, string videoAuthor, int videoTime)
    {
    _videoTitle = videoTitle;
    _videoAuthor = videoAuthor;
    _videoTime = videoTime;
    }

    public void SetComment(string name, string text)
    {
        Comment setting = new Comment(); 
        setting.SetComment2(name, text);
        _Comments.Add(setting);
    }
    public void DisplayVideoThings(int ammount)
    {
        Console.WriteLine($" Author: {_videoAuthor} Title: {_videoTitle}\nTime(in seconds): {_videoTime} Number of comments: {ammount}");
        foreach(Comment comment in _Comments)
        {
            comment.DisplayComments();
        }
    }
}