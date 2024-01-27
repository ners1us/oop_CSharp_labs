using Itmo.ObjectOrientedProgramming.Lab1.Exceptions;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Engine;

public abstract class Engine
{
    private const int MaxDistanceCoefficient = 10;
    protected Engine(int power, int torque)
    {
        if (power < 0 || torque < 0) throw new NegativeValueException("Values shouldn't be negative!");

        Power = power;
        Torque = torque;
    }

    public int Power { get; private set; }
    public int Torque { get; private set; }
    public abstract double CalculateOutputPower();

    public double CalculateMaxDistance()
    {
        return Torque * Power / MaxDistanceCoefficient;
    }
}