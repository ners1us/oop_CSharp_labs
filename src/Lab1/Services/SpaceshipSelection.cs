using Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceship;
using Itmo.ObjectOrientedProgramming.Lab1.Exceptions;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Route;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services;

public static class SpaceshipSelection
{
    public static Spaceship SelectLesserCostFuelSpaceship(Spaceship firstSpaceship, Spaceship secondSpaceship)
    {
        if (firstSpaceship == null || secondSpaceship == null) throw new ShipNullException("Ship shouldn't be null!");

        return firstSpaceship.FuelCost * firstSpaceship.Fuel > secondSpaceship.FuelCost * secondSpaceship.Fuel ? secondSpaceship : firstSpaceship;
    }

    public static Spaceship WhichIsFurtherSpaceship(Spaceship firstSpaceship, Spaceship secondSpaceship, Route route)
    {
        if (route == null) throw new PathNullException("Path shouldn't be null!");
        if (firstSpaceship == null || secondSpaceship == null) throw new ShipNullException("Ship shouldn't be null!");

        double firstSpaceshipTraveledPath = firstSpaceship.Engines[0].CalculateMaxDistance() - route.Distance;
        double secondSpaceshipTraveledPath = secondSpaceship.Engines[0].CalculateMaxDistance() - route.Distance;

        return firstSpaceshipTraveledPath > secondSpaceshipTraveledPath ? firstSpaceship : secondSpaceship;
    }

    public static Spaceship SelectBetterSpaceship(Spaceship firstSpaceship, Spaceship secondSpaceship, Route route)
    {
        if (route == null) throw new PathNullException("Path shouldn't be null!");
        if (firstSpaceship == null || secondSpaceship == null) throw new ShipNullException("Ship shouldn't be null!");

        if (SelectLesserCostFuelSpaceship(firstSpaceship, secondSpaceship) == firstSpaceship && SelectLighterSpaceship(firstSpaceship, secondSpaceship) == firstSpaceship &&
            firstSpaceship.Case.MeteoriteHealth > secondSpaceship.Case.MeteoriteHealth && WhichIsFurtherSpaceship(firstSpaceship, secondSpaceship, route) == firstSpaceship)
            return firstSpaceship;

        return secondSpaceship;
    }

    private static Spaceship SelectLighterSpaceship(Spaceship firstSpaceship, Spaceship secondSpaceship)
    {
        if (firstSpaceship == null || secondSpaceship == null) throw new ShipNullException("Ship shouldn't be null!");

        if (firstSpaceship.SpaceshipMass < secondSpaceship.SpaceshipMass &&
            firstSpaceship.SpaceshipSize < secondSpaceship.SpaceshipSize)
        {
            return firstSpaceship;
        }

        return secondSpaceship;
    }
}
