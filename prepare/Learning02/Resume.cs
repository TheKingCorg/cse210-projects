//Keeps track of the person's name and a list of their jobs
public class Resume
{
    //Member variables
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    //Constructor
    public Resume()
    {
    }

    // A method that displays the person's job information
    public void ResDisplay()
    {
        Console.WriteLine($"\nName: {_name}");
        foreach (Job singleJob in _jobs)
        {
            singleJob.DetailDisplay();
        }
        Console.WriteLine("");
    }
}