public class Video
{
    //Member variables
    private string _title;
    private string _author;
    private string _length;
    private List<Comment> _comments = new List<Comment>();

    //Constructors
    public Video(string author, string title, string length)
    {
        //Instantiate the new Video using the passed in information
        _title = title;
        _author = author;
        _length = length;
        _comments = [];
    }

    //Methods
    public void ShowComments()
    {
        //Display each Comment in the comment list
        foreach (Comment indComm in _comments)
        {
            Console.WriteLine($"{indComm.GetDisplayText()}\n");
        }   
    }

    public void AddComment(string name, string text)
    {
        //Create a new comment and add it to the video's comment list
        Comment newComm = new Comment(name,text);
        _comments.Add(newComm);
    }

    public void ShowVideoDetails()
    {
        string divider = ($"------------------------------------------------------------------");
        Console.WriteLine($"\n{_title}\nBy {_author}\nLength: {_length}\nComments: {GetCommentNumber()}\n");
    }
    public int GetCommentNumber()
    {
        int commNum = _comments.Count();
        return commNum;
    }
}