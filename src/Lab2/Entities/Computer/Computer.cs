using Itmo.ObjectOrientedProgramming.Lab2.Models.ComputerBody;
using Itmo.ObjectOrientedProgramming.Lab2.Models.CPUCoolingSystem;
using Itmo.ObjectOrientedProgramming.Lab2.Models.HDD;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Motherboard;
using Itmo.ObjectOrientedProgramming.Lab2.Models.PowerUnit;
using Itmo.ObjectOrientedProgramming.Lab2.Models.RAM;
using Itmo.ObjectOrientedProgramming.Lab2.Models.SSD;
using Itmo.ObjectOrientedProgramming.Lab2.Models.VideoCard;
using Itmo.ObjectOrientedProgramming.Lab2.Models.WiFiAdapter;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Computer;

public class Computer
{
    public Computer(
        ComputerBody? body,
        CoolingSystem? cpuCoolingSystem,
        Hdd? hardDrive,
        Motherboard? motherboard,
        Ram? ramMemory,
        Ssd? ssd,
        VideoCard? videoCard,
        WiFiAdapterWithBluetooth? wifi,
        PowerUnit? computerPowerUnit)
    {
        Body = body;
        CpuCoolingSystem = cpuCoolingSystem;
        HardDrive = hardDrive;
        Motherboard = motherboard;
        RamMemory = ramMemory;
        Ssd = ssd;
        VideoCard = videoCard;
        Wifi = wifi;
        ComputerPowerUnit = computerPowerUnit;
    }

    public PowerUnit? ComputerPowerUnit { get; private set; }
    public ComputerBody? Body { get; private set; }
    public CoolingSystem? CpuCoolingSystem { get; private set; }
    public Hdd? HardDrive { get; private set; }
    public Motherboard? Motherboard { get; private set; }
    public Ram? RamMemory { get; private set; }
    public Ssd? Ssd { get; private set; }
    public VideoCard? VideoCard { get; private set; }
    public WiFiAdapterWithBluetooth? Wifi { get; private set; }
}