namespace lab4.Task5
{
    public class TextDocumentMemento
    {
        public string SavedContent { get; }

        public TextDocumentMemento(string content)
        {
            SavedContent = content;
        }
    }
}