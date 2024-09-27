using System;

class Program
{
    static void Main(string[] args)
    {
        Journal currJournal = new Journal();
        currJournal.AddEntry();
        currJournal.AddEntry();
        currJournal.AddEntry();
        currJournal.AddEntry();
        currJournal.AddEntry();
        currJournal.SaveToFile();
    }
}