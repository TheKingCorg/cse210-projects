using System.Xml.Linq;

public class GoalManager
{
    //Member variables
    private List<Goal> _goals;
    private int _score;

    //constructors
    public GoalManager(){
        _goals = [];
        _score = 0;
    }

    //Methods
    public void Start(){
        //Clear console and show score
        Console.Clear();
        Console.WriteLine($"\nYou have {_score} points.");

        //Display menu and request input
        Console.WriteLine("\n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");
        Console.Write("Enter you selection here: ");
    }
    public void DisplayPlayerInfo(){
    }
    public void ListGoalNames(){
        //Show each goal's name
        int i = 0;
        foreach (Goal indGoal in _goals){
            //increment the goal number and print the goal name
            i++;
            Console.WriteLine($"{i}. {indGoal.GetNameString()}");
        }
    }
    public void ListGoalDetails(){
        //loop through all goals and display their info
        foreach (Goal indGoal in _goals){
            Console.WriteLine($"{indGoal.GetStringRepresentation()}");
        }
    }
    public void CreateGoal(){
    }
    public void RecordEvent(){
    }
    public void SaveGoals(){
    }
    public void LoadGoals(){
    }
}
