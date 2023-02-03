using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        Journal myJournal = new Journal();
        myJournal.showMenu();
        Entry e = new Entry();

        Console.Write("What would you like to do? ");
        int _userInput = int.Parse(Console.ReadLine()); //to convert string to int

        if( _userInput == 1)
        {
            Entry en = new Entry();
            Console.Write("How was your day? ");
            en._entry = Console.ReadLine();
            myJournal._addEntry.Add(en);
            
        }
        myJournal.showJournal();
        
    }
}