namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Engine.ImpulseEngines;

public class ImpulseEngineE : Engine
{
    private const double FirstEngineCoefficient = 0.341;
    private const double SecondEngineCoefficient = 4;
    private const int EngineEPower = 105;
    private const int EngineETorque = 250;
    public ImpulseEngineE()
        : base(EngineEPower, EngineETorque)
    { }

    public override double CalculateOutputPower()
    {
        return FirstEngineCoefficient * Power * SecondEngineCoefficient;
    }
}