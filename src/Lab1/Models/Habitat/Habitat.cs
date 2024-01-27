using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacle;
using Itmo.ObjectOrientedProgramming.Lab1.Exceptions;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Habitat;

public abstract class Habitat
{
    protected Habitat(Obstacle meteorite, Obstacle asteroid, Obstacle cosmoWhale)
    {
        if (meteorite is null || asteroid is null || cosmoWhale is null)
        {
            throw new ObstacleNullException("Obstacle shouldn't be null!");
        }

        MeteoriteQuantity = meteorite.ObstacleQuantity;
        AsteroidQuantity = asteroid.ObstacleQuantity;
        CosmowhaleQuantity = cosmoWhale.ObstacleQuantity;
    }

    public int MeteoriteQuantity { get; private set; }
    public int AsteroidQuantity { get; private set; }
    public int CosmowhaleQuantity { get; private set; }
}