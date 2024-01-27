namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacle.Obstacles;

public class SmallAsteroid : Obstacle
{
    private const int AsteroidMass = 250;
    private const int AsteroidSize = 25;
    private const int AsteroidDamage = 10;
    public SmallAsteroid(int obstacleQuantity)
        : base(AsteroidMass, AsteroidSize, AsteroidDamage, obstacleQuantity) { }
}