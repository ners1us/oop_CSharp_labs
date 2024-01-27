namespace Itmo.ObjectOrientedProgramming.Lab2.Models.CPU;

public class CpuWithInnerVideoCore : CpuDecorator
{
    public CpuWithInnerVideoCore(ICpu wrappee)
        : base(wrappee)
    {
    }
}