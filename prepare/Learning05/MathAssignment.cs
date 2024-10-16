public class MathAssignment : Assignment
{
    //Member variables
    private string _textbookSection;
    private string _problems;

    //Constructors
    public MathAssignment(){
        _textbookSection = "no section";
        _problems = "no problem set";
    }

    //Class methods
    public string GetHomeWorkList(){
        return "";
    }
}