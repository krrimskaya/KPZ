using System;
using System.Collections.Generic;

public class SmartTextChecker
{
    private readonly SmartTextReader _smartTextReader;

    public SmartTextChecker(SmartTextReader smartTextReader)
    {
        _smartTextReader = smartTextReader;
    }

    public List<List<char>> ReadFile()
    {
        Console.WriteLine($"Attempting to open file '{_smartTextReader.FileName}'...");

        var content = _smartTextReader.ReadFile();

        if (content != null)
        {
            int lineCount = content.Count;
            int charCount = 0;
            foreach (var line in content)
            {
                charCount += line.Count;
            }

            Console.WriteLine($"File '{_smartTextReader.FileName}' opened successfully.");
            Console.WriteLine($"Total lines: {lineCount}");
            Console.WriteLine($"Total characters: {charCount}");
        }
        else
        {
            Console.WriteLine($"Failed to read file '{_smartTextReader.FileName}'.");
        }

        Console.WriteLine($"File '{_smartTextReader.FileName}' closed.");
        return content;
    }
}
