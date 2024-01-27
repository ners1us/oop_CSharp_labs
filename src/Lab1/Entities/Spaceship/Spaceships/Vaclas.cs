using System.Collections.Generic;
using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab1.Models.CaseStrength;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Deflector;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Engine;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Engine.ImpulseEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Engine.JumpEngines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceship.Spaceships;

public class Vaclas : Spaceship
{
    private const int VaclasMass = 1500;
    private const int VaclasSize = 30;
    private const int VaclasFuelCost = 2400;
    public Vaclas(int fuel, Deflector vaclasDeflector, ReadOnlyCollection<Engine> vaclasEngines, CaseStrength vaclasCaseStrength)
        : base(VaclasMass, VaclasSize, vaclasDeflector, vaclasEngines, vaclasCaseStrength, fuel, VaclasFuelCost)
    {
    }

    public static ReadOnlyCollection<Engine> CreateVaclasEngines()
    {
        var enginesList = new List<Engine>
        {
            new ImpulseEngineE(),
            new Gamma(),
        };

        return new ReadOnlyCollection<Engine>(enginesList);
    }
}