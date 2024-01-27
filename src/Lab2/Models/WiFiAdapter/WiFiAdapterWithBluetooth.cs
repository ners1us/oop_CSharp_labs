namespace Itmo.ObjectOrientedProgramming.Lab2.Models.WiFiAdapter;

public class WiFiAdapterWithBluetooth : WiFiAdapterDecorator
{
    public WiFiAdapterWithBluetooth(IWiFiAdapter wrappee)
        : base(wrappee)
    {
    }
}