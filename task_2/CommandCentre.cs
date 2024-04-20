using System.Collections.Generic;

public class CommandCentre : ICommandCentre
{
    private Runway runway;
    private List<Aircraft> aircraftsInAir;

    public CommandCentre()
    {
        this.runway = new Runway();
        this.aircraftsInAir = new List<Aircraft>();
    }

    public void RequestLanding(Aircraft aircraft)
    {
        if (runway.IsBusyWithAircraft == null)
        {
            runway.IsBusyWithAircraft = aircraft;
            aircraft.CurrentRunway = runway;
            aircraftsInAir.Remove(aircraft);
            Console.WriteLine($"Aircraft {aircraft.Name} has landed.");
        }
        else
        {
            Console.WriteLine($"Could not land, the runway is busy.");
        }
    }

    public void NotifyTakeOff(Aircraft aircraft)
    {
        if (aircraft.CurrentRunway != null)
        {
            aircraftsInAir.Add(aircraft);
            aircraft.CurrentRunway.IsBusyWithAircraft = null;
            aircraft.CurrentRunway = null;
            Console.WriteLine($"Aircraft {aircraft.Name} has took off.");
        }
    }
}
