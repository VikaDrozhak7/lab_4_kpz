class Program
{
    static void Main(string[] args)
    {
        var handler1 = new ConcreteHandler1();
        var handler2 = new ConcreteHandler2();
        var handler3 = new ConcreteHandler3();
        var handler4 = new ConcreteHandler4();

        handler1.SetNext(handler2).SetNext(handler3).SetNext(handler4);

        while (true)
        {
            Console.WriteLine("Please type your request number (1, 2, 3, 4):");
            string userRequest = Console.ReadLine();
            var result = handler1.Handle(userRequest);

            if (result != null)
            {
                Console.WriteLine(result);
                break;
            }
            else
            {
                Console.WriteLine("No handler for your request. Please try again.\n");
            }
        }
    }
}
