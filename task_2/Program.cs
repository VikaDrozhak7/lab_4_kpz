class Program
{
    static void Main(string[] args)
    {
        CommandCentre commandCentre = new CommandCentre();
        Aircraft aircraft1 = new Aircraft("Aircraft 1", commandCentre);
        Aircraft aircraft2 = new Aircraft("Aircraft 2", commandCentre);

        aircraft1.Land();
        aircraft2.Land(); 

        aircraft1.TakeOff();
        aircraft2.Land(); 
    }
}
