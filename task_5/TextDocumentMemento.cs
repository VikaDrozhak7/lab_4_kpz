public class TextDocumentMemento
{
    public string Text { get; private set; }

    public TextDocumentMemento(string text)
    {
        this.Text = text;
    }
}
