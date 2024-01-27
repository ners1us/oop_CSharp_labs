using Itmo.ObjectOrientedProgramming.Lab2.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.PowerUnit;

public class PowerUnit
{
    public PowerUnit(Watt peakLoad)
    {
        PeakLoad = peakLoad;
    }

    public Watt PeakLoad { get; private set; }
}