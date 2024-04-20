class Program
{
    static void Main(string[] args)
    {
        LightElementNode div = new LightElementNode("div", true, false);
        div.AddEventListener("click", new ConsoleEventListener());

        div.TriggerEvent("click");

        Console.WriteLine(div.OuterHTML);
    }
}
