using System.Collections.Generic;
using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab1.Models.CaseStrength;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Deflector;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Engine;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Engine.ImpulseEngines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceship.Spaceships;

public class Meridian : Spaceship
{
    private const int MeridianMass = 1500;
    private const int MeridianSize = 30;
    private const int MeridianFuelCost = 3200;
    public Meridian(int fuel, Deflector meridianDeflector, ReadOnlyCollection<Engine> meridianEngines, CaseStrength meridianCaseStrength)
        : base(MeridianMass, MeridianSize, meridianDeflector, meridianEngines, meridianCaseStrength, fuel, MeridianFuelCost)
    {
    }

    public static ReadOnlyCollection<Engine> CreateMeridianEngines()
    {
        var enginesList = new List<Engine>
        {
            new ImpulseEngineE(),
        };

        return new ReadOnlyCollection<Engine>(enginesList);
    }
}