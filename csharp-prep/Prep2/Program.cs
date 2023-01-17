using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine ();

        int gradeFromUser = int.Parse(grade);

        string letter = "";

        if (gradeFromUser >= 90)
        {
            letter = "A";
        }
        else if (gradeFromUser >= 80)
        {
            letter = "B";
        }
        else if (gradeFromUser >= 70)
        {
            letter = "C";
        }
        else if (gradeFromUser >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}. ");

        if (gradeFromUser >= 70)
        {
            Console.WriteLine("Congratulations! You've passed! ");
        }
        else
        {
            Console.WriteLine("Please try again next time. You can do it!");
        }
    }
}