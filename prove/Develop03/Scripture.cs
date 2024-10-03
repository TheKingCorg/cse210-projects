public class Scripture
{
    //Member variables
    private Reference _reference;
    private List<Word> _words;

    //Constructors
    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        _words = [];
    }

    //Methods
    public void HideRandomWords(int numberToHide) //returns the value of a stored fraction's numerator
    {

    }
    public string GetDisplayText()
    { 
        return "";
    }
    public bool IsCompletelyHidden()
    {
        return true;
    }
}