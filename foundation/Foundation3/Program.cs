using System;

class Program
{
    static void Main(string[] args)
    {
        //List for storing activities
        List<Activity> activities = [];

        //Create running activity
        activities.Add(new RunningActivity(DateTime.Now.Date, 12.6F, 1.8F));

        //Create swimming activity
        activities.Add(new SwimmingActivity(DateTime.Now.Date, 30.2F, 6));

        //Create cycling activity
        activities.Add(new CyclingActivity(DateTime.Now.Date, 26.7F, 9.8F));

        //Clear and space console
        Console.Clear();
        Console.WriteLine("\n\n");
        //Dispaly the activities
        foreach (Activity activity in activities){
            Console.WriteLine(activity.GetStringRepresentation());
        }
    }
}