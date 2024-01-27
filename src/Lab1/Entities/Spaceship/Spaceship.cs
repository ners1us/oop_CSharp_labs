using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab1.Exceptions;
using Itmo.ObjectOrientedProgramming.Lab1.Models.CaseStrength;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Deflector;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Engine;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Route;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceship;

public abstract class Spaceship
{
    private const int FirstSpaceshipCoefficient = 150;
    private const int SecondSpaceshipCoefficient = 1000;
    protected Spaceship(int spaceshipMass, int spaceshipSize, Deflector? deflector, ReadOnlyCollection<Engine> engines, CaseStrength caseStrength, int fuel, int fuelCost)
    {
        if (spaceshipMass < 0 || spaceshipSize < 0 || fuel < 0 || fuelCost < 0)
            throw new NegativeValueException("Values shouldn't be negative!");

        SpaceshipMass = spaceshipMass;
        SpaceshipSize = spaceshipSize;
        Deflector = deflector;
        Engines = engines;
        Case = caseStrength;
        Fuel = fuel;
        FuelCost = fuelCost;
    }

    public int FuelCost { get; private set; }
    public bool IsCrewAlive { get; private set; } = true;
    public int SpaceshipMass { get; private set; }
    public int SpaceshipSize { get; private set; }
    public CaseStrength Case { get; private set; }
    public ReadOnlyCollection<Engine> Engines { get; private set; }

    public Deflector? Deflector { get; private set; }
    public double Fuel { get; private set; }
    public void MakeCrewStatusDead()
    {
        IsCrewAlive = false;
    }

    public bool ProcessRoute(Route route, Spaceship spaceship)
    {
        if (route == null) throw new PathNullException("Path can't be null!");

        double requiredFuel = route.Distance * CalculateFuelConsumption(route.Distance, spaceship);
        if (Fuel < requiredFuel) throw new PathIsNotEndedException($"{route} is not ended");

        Fuel -= requiredFuel;

        return true;
    }

    private static double CalculateFuelConsumption(double distance, Spaceship spaceship)
    {
        if (spaceship == null) throw new ShipNullException("Spaceship shouldn't be null");

        double outputPower;
        switch (spaceship.Engines.Count)
        {
            case 2:
                outputPower = spaceship.Engines[0].CalculateOutputPower() +
                              spaceship.Engines[1].CalculateOutputPower();
                return ((outputPower / FirstSpaceshipCoefficient) * distance) / SecondSpaceshipCoefficient;

            case 1:
                outputPower = spaceship.Engines[0].CalculateOutputPower();

                return ((outputPower / FirstSpaceshipCoefficient) * distance) / SecondSpaceshipCoefficient;

            default:
                throw new OutOfRangeException("The engine amount is out of range!");
        }
    }
}