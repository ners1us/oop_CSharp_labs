using Itmo.ObjectOrientedProgramming.Lab2.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.WiFiAdapter;

public class WiFiAdapter : IWiFiAdapter
{
    public WiFiAdapter(VersionName wiFiVersionName, Watt wiFiPowerConsumption)
    {
        WiFiVersionName = wiFiVersionName;
        WiFiPowerConsumption = wiFiPowerConsumption;
    }

    public VersionName WiFiVersionName { get; private set; }
    public Watt WiFiPowerConsumption { get; private set; }
}