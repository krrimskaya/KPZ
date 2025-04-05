using System;
using System.Collections.Generic;
using System.IO;

public class SmartTextReader
{
    public string FileName { get; }
    public List<List<char>> Content { get; private set; }

    public SmartTextReader(string fileName)
    {
        FileName = fileName;
        Content = new List<List<char>>();
    }

    public List<List<char>> ReadFile()
    {
        try
        {
            using (StreamReader reader = new StreamReader(FileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var charArray = new List<char>(line.ToCharArray());
                    Content.Add(charArray);
                }
            }

            return Content;
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"File '{FileName}' not found!");
            return null;
        }
    }
}
