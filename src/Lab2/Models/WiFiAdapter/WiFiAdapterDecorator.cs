using Itmo.ObjectOrientedProgramming.Lab2.Exceptions;
using Itmo.ObjectOrientedProgramming.Lab2.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.WiFiAdapter;

public class WiFiAdapterDecorator : IWiFiAdapter
{
    public WiFiAdapterDecorator(IWiFiAdapter wrappee)
    {
        if (wrappee is null)
            throw new NullException("Wrappee shouldn't be null!");

        Wrappee = wrappee;
        WiFiVersionName = wrappee.WiFiVersionName;
        WiFiPowerConsumption = wrappee.WiFiPowerConsumption;
    }

    public IWiFiAdapter Wrappee { get; }
    public VersionName WiFiVersionName { get; }
    public Watt WiFiPowerConsumption { get; }
}