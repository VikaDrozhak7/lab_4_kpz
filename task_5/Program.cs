class Program
{
    static void Main(string[] args)
    {
        TextEditor editor = new TextEditor();

        editor.Type("First sentence. ");
        editor.Type("Second sentence. ");

        Console.WriteLine(editor.Content());

        editor.Undo();

        Console.WriteLine(editor.Content());
    }
}
