using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToCSV(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.ToCSV());
            }
        }
    }

    public void LoadFromCSV(string filename)
    {
        _entries.Clear();

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry = new Entry(parts[0], parts[1], parts[2]);

            _entries.Add(entry);
        }
    }

    public void SaveToJSON(string filename)
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        string jsonString = JsonSerializer.Serialize(_entries, options);

        File.WriteAllText(filename, jsonString);
    }

    public void LoadFromJSON(string filename)
    {
        string jsonString = File.ReadAllText(filename);

        _entries = JsonSerializer.Deserialize<List<Entry>>(jsonString);
    }
}