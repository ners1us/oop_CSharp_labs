using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Engine.JumpEngines;

public class Gamma : Engine
{
    private const int GammaPower = 229;
    private const int GammaTorque = 300;
    public Gamma()
        : base(GammaPower, GammaTorque)
    { }
    public override double CalculateOutputPower()
    {
        return Power * Math.Log(Power);
    }
}