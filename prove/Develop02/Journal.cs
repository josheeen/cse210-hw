using System;
using System.IO;

public class Journal
{
    //Atributes
    public List<Entry> _addEntry = new List<Entry>();
    public string _displayEntry;
    public string _saveFile;
    public string _loadFile;

    
    public void showMenu()
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choice.");

        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

    }
    
    public void showJournal()
    {
        foreach (Entry i in _addEntry)
        {
            i.showEntry();
        }
    }
    
    
}