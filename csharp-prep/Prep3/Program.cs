using System;

class Program
{
    static void Main(string[] args)
    {
        //Opening spacers
        Console.WriteLine();
        Console.WriteLine();

        //Computer picks a random number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);
        
        //Start game
        Console.WriteLine("I've picked a random number from 1 to 100! \nTo win, you have to guess it correctly!\n");
        int userGuess = 0;
        string rawInput = "";
        int guessCount = 0;

        //Game loop
        do
        {
            Console.Write("Enter your guess here: ");
            rawInput = Console.ReadLine();
            userGuess = int.Parse(rawInput); //Converts user input into integer
            guessCount ++;

            //Determine and give hint
            if (userGuess > magicNumber)
            {
                Console.WriteLine($"\n{rawInput} is too high! Try lower.");
            }
            else if (userGuess < magicNumber)
            {
                Console.WriteLine($"\n{rawInput} is too low! Try higher.");
            }
        } while (userGuess != magicNumber);

        //Victory message
        Console.WriteLine($"\nWow! You guessed it right in {guessCount} guesses! Good job!");
        
        //Opening spacers
        Console.WriteLine();
        Console.WriteLine();
    }
}