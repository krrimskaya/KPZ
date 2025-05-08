namespace lab4.Task5
{
    public class TextDocument
    {
        public string Content { get; set; }

        public TextDocument(string content)
        {
            Content = content;
        }

        public TextDocumentMemento CreateMemento()
        {
            return new TextDocumentMemento(Content);
        }

        public void RestoreFromMemento(TextDocumentMemento memento)
        {
            Content = memento.SavedContent;
        }
    }
}