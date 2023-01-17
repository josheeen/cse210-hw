using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep1 World!");

        // Console.Write("What is your firstname? ");
        // string firstName = Console.ReadLine();
        // Console.Write("What is your lastname? ");
        // string lastName = Console.ReadLine();
        // Console.WriteLine ($"Your name is {lastName}, {firstName} {lastName}.");


        string input = "yes";

        while (input == "yes")
        {
            Console.Write("Do you want to continue? ");
            input = Console.ReadLine();
        }
    }
}