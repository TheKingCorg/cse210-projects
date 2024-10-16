public class Assignment
{
    //Member variables
    private string _studentName;
    private string _topic;

    //Constructors
    public Assignment(){            //Constructor for no arguments
        _studentName = "anon";
        _topic = "unknown";
    }

    public Assignment(string stuName, string topic){    //Constructor for full arugments
        _studentName = stuName;
        _topic = topic;
    }

    //Methods
    public string GetSummary(){
        return $"Name: {_studentName}, {_topic}";
    }


}