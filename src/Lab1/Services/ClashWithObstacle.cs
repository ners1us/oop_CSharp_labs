using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacle.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceship;
using Itmo.ObjectOrientedProgramming.Lab1.Exceptions;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Deflector;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Route;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services;

public static class ClashWithObstacle
{
    public static void ClashShipWithMeteorite(Spaceship spaceship, Route route, Meteorite meteorite)
    {
        if (spaceship == null) throw new ShipNullException("The ship shouldn't be null!");
        if (meteorite == null) throw new ObstacleNullException("The obstacle shouldn't be null!");
        if (route == null) throw new PathNullException("The path shouldn't be null!");

        spaceship.Case.GetMeteoriteDamageFromObstacle(meteorite.CalculateDamage(route.Habitat.MeteoriteQuantity));

        if (spaceship.Case.MeteoriteHealth <= 0)
        {
            throw new ShipDestroyedException("The ship is destroyed!");
        }
    }

    public static void ClashDeflectorWithMeteorite(Spaceship spaceship, Route route, Meteorite meteorite)
    {
        if (spaceship == null) throw new ShipNullException("The shouldn't be null!");
        if (meteorite == null) throw new ObstacleNullException("The obstacle shouldn't be null!");
        if (route == null) throw new PathNullException("The path shouldn't be null!");
        if (spaceship.Deflector == null) throw new DeflectorNullException("The deflector shouldn't be null!");

        spaceship.Deflector.GetMeteoriteDamageFromObstacle(meteorite.CalculateDamage(route.Habitat.MeteoriteQuantity));

        if (spaceship.Deflector is { MeteoriteHealth: <= 0 })
        {
            throw new DeflectorDestroyedException("The deflector is destroyed!");
        }
    }

    public static void ClashDeflectorWithAsteroid(Spaceship spaceship, Route route, SmallAsteroid asteroid)
    {
        if (spaceship == null) throw new ShipNullException("The shouldn't be null!");
        if (asteroid == null) throw new ObstacleNullException("The obstacle shouldn't be null!");
        if (route == null) throw new PathNullException("The path shouldn't be null!");
        if (spaceship.Deflector == null) throw new DeflectorNullException("The deflector shouldn't be null!");

        spaceship.Deflector.GetAsteroidDamageFromObstacle(asteroid.CalculateDamage(route.Habitat.AsteroidQuantity));
        if (spaceship.Deflector is { AsteroidHealth: <= 0 })
        {
            throw new DeflectorDestroyedException("The deflector is destroyed!");
        }
    }

    public static void DeflectFotonFlash(Deflector? deflector, Spaceship spaceship)
    {
        if (spaceship is null || deflector is null)
        {
            throw new NullException("Spaceship or deflector shouldn't contain null value!");
        }

        if (deflector.FlashHealth > 0)
        {
            deflector.GetFotonDamageFromObstacle();
        }
        else
        {
            spaceship.MakeCrewStatusDead();
            throw new CrewDeadException("The crew is dead!");
        }
    }
}