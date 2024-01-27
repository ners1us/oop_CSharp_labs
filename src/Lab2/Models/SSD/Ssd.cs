using Itmo.ObjectOrientedProgramming.Lab2.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.SSD;

public class Ssd
{
    public Ssd(string ssdConnectOption, Gigabytes ssdCapacity, Watt ssdPowerConsumption, Speed ssdMaxSpeed)
    {
        SsdConnectOption = ssdConnectOption;
        SsdCapacity = ssdCapacity;
        SsdPowerConsumption = ssdPowerConsumption;
        SsdMaxSpeed = ssdMaxSpeed;
    }

    public string SsdConnectOption { get; private set; }
    public Gigabytes SsdCapacity { get; private set; }
    public Speed SsdMaxSpeed { get; private set; }
    public Watt SsdPowerConsumption { get; private set; }
}