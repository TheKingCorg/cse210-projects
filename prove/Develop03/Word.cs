public class Word
{
    //Member variables
    private string _text;
    private bool _isHidden;

    //Constructors
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    //Methods
    public void Hide()
    {
        _isHidden = true; //Turn a word hidden
    }
    public void Show()
    {
        _isHidden = false; //unhide a hidden word
    }
    public bool IsHidden()
    {
        return _isHidden; //return the current boolean value of the Word's _isHidden attribute
    }
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            int length = _text.Length;
            return new string('_', length);
        }
        else
        {
            return ($"{_text}"); //return the text of the Word Class
        }
    }
}