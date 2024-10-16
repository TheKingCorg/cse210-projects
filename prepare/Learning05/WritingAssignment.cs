public class WritingAssignment : Assignment
{
    //Member variables
    private string _title;

    //Constructors
    public WritingAssignment(){     //Will handle no arguments
        _title = "no title";
    }

    public WritingAssignment(string stuName, string topic, string title) : base(stuName,topic){
        _title = title;
    }

    public string GetWritingInformation(){
        return $"{_title} by {_studentName}";
    }
}