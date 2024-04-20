public class TextEditor
{
    private TextDocument _textDocument;
    private Stack<TextDocumentMemento> _history;

    public TextEditor()
    {
        _textDocument = new TextDocument();
        _history = new Stack<TextDocumentMemento>();
    }

    public void Type(string words)
    {
        _history.Push(new TextDocumentMemento(_textDocument.Text));
        _textDocument.Text += words;
    }

    public void Undo()
    {
        if (_history.Count > 0)
        {
            _textDocument.Text = _history.Pop().Text;
        }
    }

    public string Content()
    {
        return _textDocument.Text;
    }
}
