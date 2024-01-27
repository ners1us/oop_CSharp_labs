using System.Collections.Generic;
using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab1.Models.CaseStrength;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Deflector;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Engine;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Engine.ImpulseEngines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceship.Spaceships;

public class Stella : Spaceship
{
    private const int StellaMass = 1000;
    private const int StellaSize = 20;
    private const int StellaFuelCost = 3005;
    public Stella(int fuel, Deflector stellaDeflector, ReadOnlyCollection<Engine> stellaEngines, CaseStrength stellaCaseStrength)
        : base(StellaMass, StellaSize, stellaDeflector, stellaEngines, stellaCaseStrength, fuel, StellaFuelCost)
    {
    }

    public static ReadOnlyCollection<Engine> CreateStellaEngines()
    {
        var enginesList = new List<Engine>
        {
            new ImpulseEngineC(),
        };

        return new ReadOnlyCollection<Engine>(enginesList);
    }
}