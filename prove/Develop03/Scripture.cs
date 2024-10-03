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
        List<string> splitText = text.Split(' ').ToList(); //turns the full text into a list of individual single-word strings
        foreach (string soloWord in splitText)
        {
            Word newWord = new Word(soloWord);  //turns single words into a word class
            _words.Add(newWord);   //stores that new word class into the scriptures listof word classes
        }
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