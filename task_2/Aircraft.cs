public class Aircraft
{
    public string Name;
    public Runway CurrentRunway { get; set; }
    private ICommandCentre commandCentre;

    public Aircraft(string name, ICommandCentre commandCentre)
    {
        this.Name = name;
        this.commandCentre = commandCentre;
    }

    public void Land()
    {
        commandCentre.RequestLanding(this);
    }

    public void TakeOff()
    {
        commandCentre.NotifyTakeOff(this);
    }
}
