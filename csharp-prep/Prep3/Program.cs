using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        //ask user for input then store in variable in which need to be declared 
        //first.
        // Console.Write("What is the magic number? "); //asking user for magic number
        // string magicNumber = Console.ReadLine();
        
        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();

        //generates a random number for 1-100 instead of asking user for a magic number
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 101);

        //converts string to integers
        // int magicNum = int.Parse(magicNumber);
        int guessNum = int.Parse(guess);

        //write if statement to check whether it was guessed right!
        if (guessNum < magicNum)
            {
                Console.WriteLine("Higher");
            }

            else if (guessNum > magicNum)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("You've guessed it!");
            }

        //added a loop to determine until it was guessed right
        while (guessNum != magicNum)
        {
            Console.Write("What is your guess? ");
            guess = Console.ReadLine(); 
            guessNum = int.Parse(guess);

            if (guessNum < magicNum)
            {
                Console.WriteLine("Higher");
            }

            else if (guessNum > magicNum)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("You've guessed it!");
            }
                
        }

        
        
    }
}