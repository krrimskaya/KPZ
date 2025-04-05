using System.Text.RegularExpressions;
public class SmartTextReaderLocker
{
    private readonly SmartTextReader _smartTextReader;
    private readonly Regex _fileAccessRule;

    public SmartTextReaderLocker(SmartTextReader smartTextReader, string filePattern)
    {
        _smartTextReader = smartTextReader;
        _fileAccessRule = new Regex(filePattern);
    }

    public List<List<char>> ReadFile()
    {
        if (_fileAccessRule.IsMatch(_smartTextReader.FileName))
        {
            // Якщо ім'я файлу відповідає регулярному виразу = повідомлення про заборону доступу
            Console.WriteLine("Access denied!");
            return null;
        }

        return _smartTextReader.ReadFile();
    }
}