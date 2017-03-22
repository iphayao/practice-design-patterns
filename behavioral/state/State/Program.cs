using System;

namespace State
{
    class Program
    {
        interface IWritingState
        {
            void Write(string words);
        }

        class UpperCase : IWritingState
        {
            public void Write(string words)
            {
                Console.WriteLine(words.ToUpper());
            }
        }

        class LowerCase : IWritingState
        {
            public void Write(string words)
            {
                Console.WriteLine(words.ToLower());
            }
        }

        class Default : IWritingState
        {
            public void Write(string words)
            {
                Console.WriteLine(words);
            }
        }

        class TextEditor
        {
            protected IWritingState state;

            public TextEditor(IWritingState state)
            {
                this.state = state;
            }

            public void SetState(IWritingState state)
            {
                this.state = state;
            }

            public void Type(string words)
            {
                this.state.Write(words);
            }
        }

        static void Main(string[] args)
        {
            TextEditor editor = new TextEditor(new Default());

            editor.Type("First Line");

            editor.SetState(new UpperCase());
            editor.Type("Second Line");
            editor.Type("Third Line");

            editor.SetState(new LowerCase());
            editor.Type("Forth Line");
            editor.Type("Fifth Line");
        }
    }
}
