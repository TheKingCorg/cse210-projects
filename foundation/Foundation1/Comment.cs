public class Comment
{
    //Member variables
    private string _name;
    private string _text;

    //Constructors
    public Comment(string author, string text)
    {
        _name = author;
        _text = text;
    }

    //Methods
    public string GetDisplayText()
    {
        string displayText = ($"{_name} commented:\n{_text}");
        return displayText;
    }
}