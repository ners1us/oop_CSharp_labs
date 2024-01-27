using Itmo.ObjectOrientedProgramming.Lab2.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.WiFiAdapter;

public interface IWiFiAdapter
{
    public VersionName WiFiVersionName { get; }
    public Watt WiFiPowerConsumption { get; }
}