namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Engine.ImpulseEngines;

public class ImpulseEngineC : Engine
{
    private const double EngineCoefficient = 0.1;
    private const int EngineCPower = 117;
    private const int EngineCTorque = 250;
    public ImpulseEngineC()
        : base(EngineCPower, EngineCTorque)
    { }

    public override double CalculateOutputPower()
    {
        return EngineCoefficient * Power;
    }
}