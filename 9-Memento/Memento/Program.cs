namespace MementoPattern
{
    using System;

    // Originator
    public class TextEditor
    {
        private string _text;

        public void Type(string words)
        {
            _text += words;
        }

        public string GetText()
        {
            return _text;
        }

        public Memento Save()
        {
            return new Memento(_text);
        }

        public void Restore(Memento memento)
        {
            _text = memento.GetSavedText();
        }
    }

    // Memento
    public class Memento
    {
        private readonly string _text;

        public Memento(string text)
        {
            _text = text;
        }

        public string GetSavedText()
        {
            return _text;
        }
    }

    // Caretaker
    public class History
    {
        private Stack<Memento> _history = new Stack<Memento>();

        public void SaveState(TextEditor editor)
        {
            _history.Push(editor.Save());
        }

        public void Undo(TextEditor editor)
        {
            if (_history.Count > 0)
            {
                Memento memento = _history.Pop();
                editor.Restore(memento);
            }
        }
    }

    // Client
    class Program
    {
        static void Main()
        {
            TextEditor editor = new TextEditor();
            History history = new History();

            editor.Type("Hello, ");
            history.SaveState(editor);

            editor.Type("world!");
            Console.WriteLine(editor.GetText()); // Output: Hello, world!

            history.Undo(editor);
            Console.WriteLine(editor.GetText()); // Output: Hello, 
        }
    }
}
