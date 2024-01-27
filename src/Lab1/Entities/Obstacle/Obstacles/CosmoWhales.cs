namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacle.Obstacles;

public class CosmoWhales : Obstacle
{
    private const int CosmoWhaleDamage = 200;
    private const int CosmoWhaleMass = 1500;
    private const int CosmoWhaleSize = 100;
    public CosmoWhales(int obstacleQuantity)
        : base(CosmoWhaleMass, CosmoWhaleSize, CosmoWhaleDamage, obstacleQuantity)
    {
    }
}