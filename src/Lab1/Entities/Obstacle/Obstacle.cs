using Itmo.ObjectOrientedProgramming.Lab1.Exceptions;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacle;

public abstract class Obstacle
{
    protected Obstacle(int obstacleMass, int obstacleSize, int damage, int obstacleQuantity)
    {
        if (obstacleMass < 0 || obstacleSize < 0 || damage < 0 || obstacleQuantity < 0) throw new NegativeValueException("Values shouldn't be negative!");

        ObstacleMass = obstacleMass;
        ObstacleSize = obstacleSize;
        BaseDamage = damage;
        ObstacleQuantity = obstacleQuantity;
    }

    public int BaseDamage { get; private set; }
    public int ObstacleMass { get; private set; }
    public int ObstacleSize { get; private set; }
    public int ObstacleQuantity { get; private set; }

    public int CalculateDamage(int quantity)
    {
        if (quantity < 0) throw new NegativeValueException("Value shouldn't be negative!");

        return BaseDamage * quantity;
    }
}