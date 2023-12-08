/*using System;
using System.Collections.Generic;

/*public class Video
{
    // Declare fields for the title, author, and length of the video
    //private string title;
    //private string author;
    //private int length;

    // Declare a field for the list of comments
    private List<Comment> comments;

    // Define a constructor that takes the title, author, and length as parameters
    public Video(string title, string author, int length)
    {
       this.title = title;
        this.author = author;
        this.length = length;

        // Initialize the list of comments as an empty list
        comments = new List<Comment>();
    }
       
    public string PrintVideo()
    {
        return $"title: {title}, author: {author}, length: {length} ";
    }
}*/
/*class Video
{
    // Properties of video
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    public int Likes { get; set; }
    public int Dislikes { get; set; }
    public List<Comment> Comments { get; set; }

    // Constructor of video
    public Video(string title, string author, int length, int likes, int dislikes)
    {
        Title = title;
        Author = author;
        Length = length;
        Likes = likes;
        Dislikes = dislikes;
        Comments = new List<Comment>(); // Initialize an empty list of comments
    }

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    // Method to print the video details
    public void PrintVideo()
    {
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Length: " + Length);
        Console.WriteLine("Likes: " + Likes);
        Console.WriteLine("Dislikes: " + Dislikes);
        Console.WriteLine("Comments: ");
        //return $"Title: {title}, Author: {author}, Length: {length}, Likes: {likes}, Dislikes: {dislikes} ";
    //void int GetNumberOfComments()
    {
        //return Video.comments.Count;
    }

        foreach (Comment comment in Comments) // Loop through the list of comments
        {
            comment.PrintComment(); // Print each comment
        }
        Console.WriteLine();
    }
}*/
using System;

public class Video
{
    private List<Comment> _comments;
    private string _title;
    private string _author;
    private double _vidLength;
    

    public Video(string aTitle, string aAuthor, double aSeconds)
    {
        _title = aTitle;
        _author = aAuthor;
        _vidLength = aSeconds;

        _comments = new List<Comment>();
    }
    public Video()
    {
        
    }
    public int GetNumberOfComments()
    {
        return _comments.Count();
    }
    public void SetComment(string aName, string aText)
    {
        _comments.Add(new Comment(aName, aText));
    }
    public void DisplayComments()
    {
        int i= 1;
        foreach (Comment comment in _comments)
        {   
            Console.WriteLine($"{i} - {comment.GetCommentInfo()}");
            i++;
        }
        
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Video Title: {_title}, Author: {_author}, Length of video: {_vidLength} Seconds, Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine($"Comments:\n");
        DisplayComments();
        Console.WriteLine();
    }
}