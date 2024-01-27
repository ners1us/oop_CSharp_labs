using System.Collections.Generic;
using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab1.Models.CaseStrength;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Deflector;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Engine;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Engine.ImpulseEngines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceship.Spaceships;

public class PleasureShuttle : Spaceship
{
    private const int PleasureShuttleMass = 1000;
    private const int PleasureShuttleSize = 20;
    private const int PleasureShuttleFuelCost = 2600;
    public PleasureShuttle(int fuel, Deflector? shuttleDeflector, ReadOnlyCollection<Engine> shuttleEngines, CaseStrength shuttleCaseStrength)
        : base(PleasureShuttleMass, PleasureShuttleSize, shuttleDeflector, shuttleEngines, shuttleCaseStrength, fuel, PleasureShuttleFuelCost)
    {
    }

    public static ReadOnlyCollection<Engine> CreateShuttleEngines()
    {
        var enginesList = new List<Engine>
        {
            new ImpulseEngineC(),
        };

        return new ReadOnlyCollection<Engine>(enginesList);
    }
}