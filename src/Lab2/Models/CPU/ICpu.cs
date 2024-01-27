using Itmo.ObjectOrientedProgramming.Lab2.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.CPU;

public interface ICpu
{
    public Frequency CpuCoreFrequency { get; }
    public Amount CpuCoreAmount { get; }
    public Frequency SupportedFrequencyOfMemory { get; }
    public Tdp CpuTdpConsumption { get; }
    public Watt CpuPowerConsumption { get; }
}