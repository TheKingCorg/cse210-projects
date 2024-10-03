using System;

class Program
{
    static void Main(string[] args)
    {
        string scripText = File.ReadLines("SampleScripture.txt").ElementAtOrDefault(1); //Store the scripture's full text into a string
        Reference targScrip = new Reference("Romans", 8, 16, 17);
        Scripture toMemorize = new Scripture(targScrip, scripText);
    }
}