using System;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Models.ComputerBody;
using Itmo.ObjectOrientedProgramming.Lab2.Models.CPUCoolingSystem;
using Itmo.ObjectOrientedProgramming.Lab2.Models.HDD;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Motherboard;
using Itmo.ObjectOrientedProgramming.Lab2.Models.PowerUnit;
using Itmo.ObjectOrientedProgramming.Lab2.Models.RAM;
using Itmo.ObjectOrientedProgramming.Lab2.Models.SSD;
using Itmo.ObjectOrientedProgramming.Lab2.Models.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab2.Models.VideoCard;
using Itmo.ObjectOrientedProgramming.Lab2.Models.WiFiAdapter;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Repository;

public class Repository
{
    private readonly Warehouse.Warehouse _warehouse;

    public Repository(Warehouse.Warehouse warehouse)
    {
        _warehouse = warehouse;
    }

    public ComputerBody FindComputerBodyBySize(Size size)
    {
        return _warehouse.ComputerBodies.SingleOrDefault(cb => cb.CaseSize.Value == size.Value) ?? throw new InvalidOperationException();
    }

    public Motherboard FindMotherboardByYear(Year dateTime)
    {
        return _warehouse.Motherboards.SingleOrDefault(mb => mb.YearOfRelease.Value == dateTime.Value) ?? throw new InvalidOperationException();
    }

    public CoolingSystem FindCoolingSystemBySize(Size size)
    {
        return _warehouse.CoolingSystems.FirstOrDefault(cs => cs.CoolingSystemSize.Value == size.Value) ?? throw new InvalidOperationException();
    }

    public Ssd FindSsdByType(Kind type)
    {
        return _warehouse.Ssds.FirstOrDefault(ssd => ssd.SsdConnectOption == type.Value) ?? throw new InvalidOperationException();
    }

    public VideoCard FindVideoCardByFrequency(Frequency frequency)
    {
        return _warehouse.VideoCards.FirstOrDefault(vc => vc.ChipFrequency.Value == frequency.Value) ?? throw new InvalidOperationException();
    }

    public WiFiAdapterWithBluetooth FindWiFiAdapterByVersion(VersionName version)
    {
        return _warehouse.WiFiAdapters.FirstOrDefault(wa => wa.WiFiVersionName.Value == version.Value) ?? throw new InvalidOperationException();
    }

    public PowerUnit FindPowerUnitByWatt(Watt watt)
    {
        return _warehouse.PowerUnits.FirstOrDefault(pu => pu.PeakLoad.Value == watt.Value) ?? throw new InvalidOperationException();
    }

    public Ram FindRamByGigabytes(Gigabytes gigabytes)
    {
        return _warehouse.Rams.FirstOrDefault(ram => ram.AvailableMemoryAmount.Value == gigabytes.Value) ?? throw new InvalidOperationException();
    }

    public Hdd FindHddBySpeed(Speed speed)
    {
        return _warehouse.Hdds.FirstOrDefault(hdd => hdd.SpindleSpeed.Value == speed.Value) ?? throw new InvalidOperationException();
    }
}
