using Itmo.ObjectOrientedProgramming.Lab2.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.HDD;

public class Hdd
{
    public Hdd(Gigabytes hddCapacity, Speed spindleSpeed, Watt hddPowerConsumption)
    {
        HddCapacity = hddCapacity;
        SpindleSpeed = spindleSpeed;
        HddPowerConsumption = hddPowerConsumption;
    }

    public Gigabytes HddCapacity { get; private set; }
    public Speed SpindleSpeed { get; private set; }
    public Watt HddPowerConsumption { get; private set; }
}