using System.Collections.Generic;

namespace lab4.Task5
{
    public class TextEditor
    {
        private readonly TextDocument _document;
        private readonly Stack<TextDocumentMemento> _history = new Stack<TextDocumentMemento>();

        public TextEditor(string initialContent)
        {
            _document = new TextDocument(initialContent);
            Save();
        }

        public void Edit(string newContent)
        {
            Save();
            _document.Content = newContent;
        }

        public void Save()
        {
            _history.Push(_document.CreateMemento());
        }

        public void Undo()
        {
            if (_history.Count > 1)
            {
                _history.Pop(); // Поточний стан
                _document.RestoreFromMemento(_history.Peek());
            }
        }

        public string GetContent()
        {
            return _document.Content;
        }
    }
}