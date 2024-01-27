using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacle;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Habitat.Habitats;

public class Space : Habitat
{
    public Space(Obstacle meteoriteQuantity, Obstacle asteroidQuantity, Obstacle cosmowhaleQuantity)
        : base(meteoriteQuantity, asteroidQuantity, cosmowhaleQuantity)
    {
    }
}