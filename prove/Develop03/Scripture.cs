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
        Random random = new Random(); //random for use in hiding random words
        int scriptLength = _words.Count; //The word count of whatever scripture is stored in the class
        List<int> indexToHide = [];
        for (int i = 0; i<numberToHide; i++)   //This loop will find 3 unhidden words to hide
        {
            int randIndex = random.Next(scriptLength + 1); //pick a random word from the list
            if (_words[randIndex].IsHidden()) //check if it's hidden
            { 
                i -= 1; //if it is, decrement i so you'll loop through again
            }
            else
            {
                _words[randIndex].Hide();   //if not, hide the word
            }
        }

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