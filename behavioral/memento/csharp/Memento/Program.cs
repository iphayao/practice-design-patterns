using System;

namespace Memento
{
    class EditorMemento
    {
        protected string content;
        public EditorMemento(string content)
        {
            this.content = content;
        }
        public string GetContent()
        {
            return this.content;
        }
    }

    class Editor
    {
        protected string content = string.Empty;
        public void type(string words)
        {
            this.content = this.content + ' ' + words;
        }
        public string GetContent()
        {
            return this.content;
        }
        public EditorMemento save()
        {
            return new EditorMemento(this.content);
        }
        public void Restore(EditorMemento memento)
        {
            this.content = memento.GetContent();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Editor editor = new Editor();
            // Type some stuff
            editor.type("This is the first sentence.");
            editor.type("This is second.");
            // Save the state to reserve to : this is the first sentence. this is second.
            EditorMemento saved = editor.save();
            // Type some more
            editor.type("And this is third");
            // Output content before saving
            Console.WriteLine(editor.GetContent());
            // Restoring to last saved state
            editor.Restore(saved);
            // Output restored state
            Console.WriteLine(editor.GetContent());
        }
    }
}
