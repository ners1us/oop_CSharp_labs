using System.Collections.Generic;
using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab2.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.CPUCoolingSystem;

public class CoolingSystem
{
    public CoolingSystem(Size coolingSystemSize, Tdp maxTdpConsumption, ReadOnlyCollection<Socket> supportedSockets)
    {
        CoolingSystemSize = coolingSystemSize;
        MaxTdpConsumption = maxTdpConsumption;
        SupportedSockets = supportedSockets;
    }

    public Size CoolingSystemSize { get; private set; }
    public Tdp MaxTdpConsumption { get; private set; }
    public ICollection<Socket> SupportedSockets { get; private set; }
}