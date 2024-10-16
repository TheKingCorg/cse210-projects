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

    public MathAssignment(string stuName, string topic, string textbookSection, string problems) : base(stuName, topic){
        _textbookSection = textbookSection;
        _problems = problems;
    }

    //Class methods
    public string GetHomeWorkList(){
        return $"{_textbookSection}\n#: {_problems}";
    }
}