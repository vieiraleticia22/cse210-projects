using System;
using System.IO;
using System.Collections.Generic;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        Console.WriteLine("Displaying journal entries...");

        Console.WriteLine($"Total entries: {_entries.Count}");

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }

        Console.WriteLine("End of journal entries.");
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(
                    $"{entry._date}|{entry._mood}|{entry._promptText}|{entry._entryText}"
                );
            }
        }

        Console.WriteLine("Journal saved successfully!");
    }

    public void LoadFromFile(string fileName)
    {
        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear();

        string[] lines = File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            if (parts.Length == 4)
            {
                Entry entry = new Entry();

                entry._date = parts[0];
                entry._promptText = parts[1];
                entry._entryText = parts[2];

                _entries.Add(entry);
            }
        }

        Console.WriteLine("Journal loaded successfully!");
    }
}