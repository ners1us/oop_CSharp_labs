using System.Collections.Generic;
using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab1.Models.CaseStrength;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Deflector;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Engine;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Engine.ImpulseEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Engine.JumpEngines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceship.Spaceships;

public class Augur : Spaceship
{
    private const int AugurMass = 2000;
    private const int AugurSize = 50;
    private const int AugurFuelCost = 5000;
    public Augur(int fuel, Deflector augurDeflector, ReadOnlyCollection<Engine> augurEngines, CaseStrength augurCaseStrength)
        : base(AugurMass, AugurSize, augurDeflector, augurEngines, augurCaseStrength, fuel, AugurFuelCost)
    {
    }

    public static ReadOnlyCollection<Engine> CreateAugurEngines()
    {
        var enginesList = new List<Engine>
        {
            new ImpulseEngineE(),
            new Alpha(),
        };

        return new ReadOnlyCollection<Engine>(enginesList);
    }
}