namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacle.Obstacles;

public class Meteorite : Obstacle
{
    private const int MeteoriteMass = 500;
    private const int MeteoriteSize = 50;
    private const int MeteoriteDamage = 20;
    public Meteorite(int obstacleQuantity)
        : base(MeteoriteMass, MeteoriteSize, MeteoriteDamage, obstacleQuantity) { }
}