using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacle;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Habitat.Habitats;

public class NitrineNebula : Habitat
{
    public NitrineNebula(Obstacle meteoriteQuantity, Obstacle asteroidQuantity, Obstacle cosmowhaleQuantity)
        : base(meteoriteQuantity, asteroidQuantity, cosmowhaleQuantity)
    {
    }
}