using Itmo.ObjectOrientedProgramming.Lab1.Exceptions;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Route;

public class Route
{
    public Route(Habitat.Habitat habitat, int distance)
    {
        if (distance < 0) throw new NegativeValueException("Value shouldn't be negative");

        Habitat = habitat;
        Distance = distance;
    }

    public Habitat.Habitat Habitat { get; private set; }
    public double Distance { get; private set; }
}