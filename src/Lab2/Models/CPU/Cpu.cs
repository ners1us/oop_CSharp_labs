using Itmo.ObjectOrientedProgramming.Lab2.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.CPU;

public class Cpu : ICpu
{
    public Cpu(Frequency coreFrequency, Amount coreAmount, Frequency supportedFrequencyOfMemory, Tdp cpuTdpConsumption, Watt powerConsumption)
    {
        CpuCoreFrequency = coreFrequency;
        CpuCoreAmount = coreAmount;
        SupportedFrequencyOfMemory = supportedFrequencyOfMemory;
        CpuTdpConsumption = cpuTdpConsumption;
        CpuPowerConsumption = powerConsumption;
    }

    public Frequency CpuCoreFrequency { get; private set; }
    public Amount CpuCoreAmount { get; private set; }
    public Frequency SupportedFrequencyOfMemory { get; private set; }
    public Tdp CpuTdpConsumption { get; private set; }
    public Watt CpuPowerConsumption { get; private set; }
}