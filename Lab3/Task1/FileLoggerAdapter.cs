namespace FileLoggerApp
{
    public class FileLoggerAdapter : Logger
    {
        private FileWriter _fileWriter;

        public FileLoggerAdapter(FileWriter fileWriter)
        {
            _fileWriter = fileWriter;
        }

        public new void Log(string message)
        {
            base.Log(message);  // екран
            _fileWriter.WriteLine(message);  // файл
        }

        public new void Error(string message)
        {
            base.Error(message);  // екран
            _fileWriter.WriteLine(message);  // файл
        }

        public new void Warn(string message)
        {
            base.Warn(message);  // екран
            _fileWriter.WriteLine(message);  // файл
        }
    }
}
