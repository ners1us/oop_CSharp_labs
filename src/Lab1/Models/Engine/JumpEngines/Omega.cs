using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Engine.JumpEngines;

public class Omega : Engine
{
    private const int OmegaPower = 210;
    private const int OmegaTorque = 300;
    private const int Degree = 2;
    public Omega()
        : base(OmegaPower, OmegaTorque)
    { }
    public override double CalculateOutputPower()
    {
        return Math.Pow(Power, Degree);
    }
}