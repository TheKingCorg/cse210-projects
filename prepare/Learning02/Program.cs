using System;

class Program
{
    static void Main(string[] args)
    {
        //Create a new Job
        Job job1 = new Job();
        job1._jobTitle = "Rodeo clown";
        job1._company = "Chuckles Clown Service LLC";
        job1._startYear = 1998;
        job1._endYear = 2018;

        //Create a new Job
        Job job2 = new Job();
        job2._company = "Walmart";
        job2._jobTitle = "Emergency Kangaroo Wrangler";
        job2._startYear = 2021;
        job2._endYear = 2021;

        //New Resume instance
        Resume myResume = new Resume();
        myResume._name = "Wyatt";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.ResDisplay();

    }
}