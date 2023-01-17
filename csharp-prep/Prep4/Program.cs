using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        



        List<int> num = new List<int>();

        Console.Write("Enter a number: ");
        int userNum = int.Parse(Console.ReadLine());

        
        num.Add(userNum);
        

       
        while (userNum != 0)
        {
            Console.Write("Enter a number: ");
            userNum = int.Parse(Console.ReadLine());
            if (userNum != 0)
            {
                num.Add(userNum);
            }
            
        }
        // Console.WriteLine(num.Count);
        
        float total = num.Sum();
        int pieces = num.Count();
        float avg = total / pieces;
        int max = num.Max();

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is {avg}");
        Console.WriteLine($"The largest number is {max}");
    }
}