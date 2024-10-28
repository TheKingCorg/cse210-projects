using System.Xml.Linq;
using System.IO;

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
            Console.WriteLine($"{indGoal.GetDetailsString()}");
        }
    }
    public void CreateGoal(){
        //Present choices for user to pick from
        Console.WriteLine("\nWhat kind of goal would you like to create?\n  1. Simple Goal\n  2. Checklist Goal\n  3. Eternal Goal");
        Console.Write("Enter your choice here: ");
        string userChoice = Console.ReadLine();

        //Depending on the type, gather necessary info and pass it into the constructor
        switch (userChoice){
            case "1":
                //build a simple goal
                Console.Write("\nEnter your goal's name: ");
                string name = Console.ReadLine();
                Console.Write("\nEnter a brief description: ");
                string description = Console.ReadLine();
                Console.Write("\nHow many points is it worth: ");
                string points = Console.ReadLine();
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            
            case "2":
                //build a checklist goal
                Console.Write("\nEnter your goal's name: ");
                string checkName = Console.ReadLine();
                Console.Write("\nEnter a brief description: ");
                string checkDescription = Console.ReadLine();
                Console.Write("\nHow many points is it worth: ");
                string checkPoints = Console.ReadLine();
                Console.Write("\nHow many times should you complete this goal: ");
                int target = Int32.Parse(Console.ReadLine());
                Console.Write($"\nHow many bonus points should you earn after completing it {target} times: ");
                int bonus = Int32.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(checkName, checkDescription, checkPoints, target, bonus));
                break;
            
            case "3":
                //build an eternal goal
                Console.Write("\nEnter your goal's name: ");
                string eterName = Console.ReadLine();
                Console.Write("\nEnter a brief description: ");
                string eterDescription = Console.ReadLine();
                Console.Write("\nHow many points is it worth: ");
                string eterPoints = Console.ReadLine();
                _goals.Add(new SimpleGoal(eterName, eterDescription, eterPoints));
                break;
            
            default:
                //Display an error
                Console.Clear();
                Console.WriteLine("Error: selection invalid");
                Thread.Sleep(2000);
                break;
        }
    }
    public void RecordEvent(){
        //List goals and ask which is to be recorded 
        Console.WriteLine("\nWhich goal did you accomplish?");
        ListGoalNames();
        Console.Write("Enter your selection here: ");
        //cast userChoice as an int
        int userChoice = Int32.Parse(Console.ReadLine());

        //Ensure that the selected goal gets a recorded event
        int earned = _goals[userChoice-1].RecordEvent();
        //Add the earned score to total
        _score += earned;

    }
    public void SaveGoals(){
        //Obtain destination file name
        Console.WriteLine("You can save your file to any .txt file.");
        Console.Write("\nEnter the name of the file: ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName)){
            //Clear the target file
            File.WriteAllText(fileName, String.Empty);
            //start file with _score
            outputFile.WriteLine(_score);

            //Write each goal to the file
            foreach (Goal indGoal in _goals){
                outputFile.WriteLine(indGoal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals(){
    }
}
