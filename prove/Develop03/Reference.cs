public class Reference
{
    //Member variables
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    //Constructors
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;
    }
    public Reference(string book,int chapter,int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    //Methods
    public string GetDisplayText() //returns the text version of the reference
    {
        if (_endVerse == 0)
        {
            return ($"{_book} {_chapter}:{_verse}");
        }
        else
        {
            return ($"{_book} {_chapter}:{_verse}-{_endVerse}");
        }
    }
}