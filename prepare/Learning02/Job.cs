// Keeps track of the company, job title, start year, and end year.
public class Job
{
    //Member variables
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear;
    public int _endYear;

    //Constructor
    public Job()
    {
    }

    // A method that displays the person's job information
    public void DetailDisplay()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}