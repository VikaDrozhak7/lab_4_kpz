public class ConsoleEventListener : IEventListener
{
    public void Update(string eventType, LightElementNode node)
    {
        Console.WriteLine($"Event '{eventType}' was triggered on element '{node.TagName}'.");
    }
}
