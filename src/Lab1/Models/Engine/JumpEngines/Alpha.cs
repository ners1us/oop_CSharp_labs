namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Engine.JumpEngines;

public class Alpha : Engine
{
    private const int AlphaPower = 210;
    private const int AlphaTorque = 300;

    public Alpha()
        : base(AlphaPower, AlphaTorque)
    { }
    public override double CalculateOutputPower()
    {
        return Power;
    }
}