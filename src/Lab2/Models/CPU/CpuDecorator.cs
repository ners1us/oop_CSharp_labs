using Itmo.ObjectOrientedProgramming.Lab2.Exceptions;
using Itmo.ObjectOrientedProgramming.Lab2.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.CPU;

public abstract class CpuDecorator : ICpu
{
    protected CpuDecorator(ICpu wrappee)
    {
        if (wrappee is null)
            throw new NullException("Wrappee shouldn't be null!");

        Wrappee = wrappee;
        CpuCoreFrequency = wrappee.CpuCoreFrequency;
        CpuCoreAmount = wrappee.CpuCoreAmount;
        SupportedFrequencyOfMemory = wrappee.SupportedFrequencyOfMemory;
        CpuTdpConsumption = wrappee.CpuTdpConsumption;
        CpuPowerConsumption = wrappee.CpuPowerConsumption;
    }

    public ICpu Wrappee { get; }
    public Frequency CpuCoreFrequency { get; }
    public Amount CpuCoreAmount { get; }
    public Frequency SupportedFrequencyOfMemory { get; }
    public Tdp CpuTdpConsumption { get; }
    public Watt CpuPowerConsumption { get; }
}