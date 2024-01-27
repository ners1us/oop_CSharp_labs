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

public interface IComputerBuilder
{
    void AddComputerCase(ComputerBody? computerCase);
    void AddCpuCoolingSystem(CoolingSystem? coolingSystem);
    void AddHdd(Hdd? hdd);
    void AddMotherboard(Motherboard? motherboard);
    void AddRam(Ram? ram);
    void AddSsd(Ssd? ssd);
    void AddGraphicsCard(VideoCard? videoCard);
    void AddWiFiAdapter(WiFiAdapterWithBluetooth? wiFiAdapter);
    void AddPowerUnit(PowerUnit? powerUnit);
    Computer BuildComputer();
}
