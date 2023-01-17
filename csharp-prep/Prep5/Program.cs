using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        // PromtpUserName();
        // PromptUserNumber();
        DisplayResult();
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromtpUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int squareNum)
    {
        int squareNumber = squareNum * squareNum;
        return squareNumber;
    }

    static void DisplayResult()
    {
        string name = PromtpUserName();
        int number = PromptUserNumber();
        int squareD = SquareNumber(number);
        Console.WriteLine($"{name}, the square of your number is {squareD}");
    }


}

//teacher solution at bottom

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         DisplayWelcomeMessage();

//         string userName = PromptUserName();
//         int userNumber = PromptUserNumber();

//         int squaredNumber = SquareNumber(userNumber);

//         DisplayResult(userName, squaredNumber);
//     }

//     static void DisplayWelcomeMessage()
//     {
//         Console.WriteLine("Welcome to the program!");
//     }

//     static string PromptUserName()
//     {
//         Console.Write("Please enter your name: ");
//         string name = Console.ReadLine();

//         return name;
//     }

//     static int PromptUserNumber()
//     {
//         Console.Write("Please enter your favorite number: ");
//         int number = int.Parse(Console.ReadLine());

//         return number;
//     }

//     static int SquareNumber(int number)
//     {
//         int square = number * number;
//         return square;
//     }

//     static void DisplayResult(string name, int square)
//     {
//         Console.WriteLine($"{name}, the square of your number is {square}");
//     }
// }