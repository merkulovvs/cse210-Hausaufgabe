using System;
using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach(Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText}");
            Console.WriteLine($"{entry._entryText}");
            Console.WriteLine("");
        }
    }

    public void SaveToFile(string file)
    {
        using(StreamWriter outputFile = new StreamWriter(file))
        {
            foreach(Entry e in _entries)
            {
                outputFile.WriteLine($"Date: {e._date} - Prompt: {e._promptText}");
                outputFile.WriteLine($"{e._entryText}");
                outputFile.WriteLine("");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        
        foreach(string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}