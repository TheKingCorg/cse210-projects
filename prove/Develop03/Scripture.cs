using System.ComponentModel.DataAnnotations;

public class Scripture
{
    //Member variables
    private Reference _reference;
    private List<Word> _words;
    private bool _completelyHidden;

    //Constructors
    public Scripture(Reference Reference, string text)
    {
        _completelyHidden = false;
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
        int failedHideAttempts = 0;
        for (int i = 0; i<numberToHide; i++)   //This loop will find 3 unhidden words to hide
        {
            int randIndex = random.Next(scriptLength + 1); //pick a random word from the list
            if (_words[randIndex].IsHidden()) //check if it's hidden
            { 
                i -= 1; //if it is, decrement i so you'll loop through again
                failedHideAttempts += 1;
            }
            else
            {
                _words[randIndex].Hide();   //if not, hide the word
            }

            //break the loop if it can't find any more words to hide, this stops an infinite loop
            if (failedHideAttempts == 100)
            {
                _completelyHidden = true;
                break;
            }
        }

    }
    public string GetDisplayText() //Returns the string to be printed, including blank spaces
    { 
        int wordCount = 0; //for use in tracking word count to start a new line
        string newLine = "\n";
        string displayText = ($"{_reference.GetDisplayText()} ");
        foreach (Word indWord in _words)
        {
            string wordText = indWord.GetDisplayText();
            displayText += (wordText + " "); //add the new word or blank onto the text string
            wordCount += 1;

            //add a new line after every seven words
            if (wordCount % 12 == 0)
            {
                displayText += newLine;
            }
        }
        return displayText;
    }
    public bool IsCompletelyHidden()
    {
        return _completelyHidden;
    }
}