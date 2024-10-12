public class Video
{
    //Member variables
    private string _title;
    private string _author;
    private string _length;
    private List<Comment> _comments = new List<Comment>();

    //Constructors
    public Video(string title, string author, string length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = [];
    }

    //Methods
    public void ShowComments()
    {
        
    }
    public void AddComment()
    {
    
    }
    public void ShowVideoDetails()
    {
    
    }
    public int GetCommentNumber()
    {
        return 0;
    }
}