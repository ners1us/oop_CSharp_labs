using Itmo.ObjectOrientedProgramming.Lab2.Models.ComputerBody;
using Itmo.ObjectOrientedProgramming.Lab2.Models.CPUCoolingSystem;
using Itmo.ObjectOrientedProgramming.Lab2.Models.HDD;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Motherboard;
using Itmo.ObjectOrientedProgramming.Lab2.Models.PowerUnit;
using Itmo.ObjectOrientedProgramming.Lab2.Models.RAM;
using Itmo.ObjectOrientedProgramming.Lab2.Models.SSD;
using Itmo.ObjectOrientedProgramming.Lab2.Models.VideoCard;
using Itmo.ObjectOrientedProgramming.Lab2.Models.WiFiAdapter;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Computer.Builder;

public class ComputerBuilder : IComputerBuilder
{
    private ComputerBody? _computerCase;
    private CoolingSystem? _coolingSystem;
    private Hdd? _hdd;
    private Motherboard? _motherboard;
    private Ram? _ram;
    private Ssd? _ssd;
    private VideoCard? _videoCard;
    private WiFiAdapterWithBluetooth? _wiFiAdapter;
    private PowerUnit? _powerUnit;

    public void AddComputerCase(ComputerBody? computerCase)
    {
        _computerCase = computerCase;
    }

    public void AddCpuCoolingSystem(CoolingSystem? coolingSystem)
    {
        _coolingSystem = coolingSystem;
    }

    public void AddHdd(Hdd? hdd)
    {
        _hdd = hdd;
    }

    public void AddMotherboard(Motherboard? motherboard)
    {
        _motherboard = motherboard;
    }

    public void AddRam(Ram? ram)
    {
        _ram = ram;
    }

    public void AddSsd(Ssd? ssd)
    {
        _ssd = ssd;
    }

    public void AddGraphicsCard(VideoCard? videoCard)
    {
        _videoCard = videoCard;
    }

    public void AddWiFiAdapter(WiFiAdapterWithBluetooth? wiFiAdapter)
    {
        _wiFiAdapter = wiFiAdapter;
    }

    public void AddPowerUnit(PowerUnit? powerUnit)
    {
        _powerUnit = powerUnit;
    }

    public Computer BuildComputer()
    {
        return new Computer(_computerCase, _coolingSystem, _hdd, _motherboard, _ram, _ssd, _videoCard, _wiFiAdapter, _powerUnit);
    }
}