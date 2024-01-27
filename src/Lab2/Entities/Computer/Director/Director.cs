using Itmo.ObjectOrientedProgramming.Lab2.Entities.Computer.Builder;
using Itmo.ObjectOrientedProgramming.Lab2.Exceptions;
using Itmo.ObjectOrientedProgramming.Lab2.Models.ComputerBody;
using Itmo.ObjectOrientedProgramming.Lab2.Models.CPUCoolingSystem;
using Itmo.ObjectOrientedProgramming.Lab2.Models.HDD;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Motherboard;
using Itmo.ObjectOrientedProgramming.Lab2.Models.PowerUnit;
using Itmo.ObjectOrientedProgramming.Lab2.Models.RAM;
using Itmo.ObjectOrientedProgramming.Lab2.Models.SSD;
using Itmo.ObjectOrientedProgramming.Lab2.Models.VideoCard;
using Itmo.ObjectOrientedProgramming.Lab2.Models.WiFiAdapter;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Computer.Director;

public class Director
{
    private readonly IComputerBuilder _computerBuilder;

    public Director(IComputerBuilder computerBuilder)
    {
        _computerBuilder = computerBuilder;
    }

    public Computer BuildCustomComputer(ComputerBody? computerCase, CoolingSystem? coolingSystem, Motherboard? motherboard, Hdd? hdd, Ssd? ssd, VideoCard? videoCard, WiFiAdapterWithBluetooth wiFiAdapter, PowerUnit? powerUnit, Ram? ram)
    {
        if (computerCase is null || coolingSystem is null || motherboard is null)
            throw new NullException("Values found to be null!");

        if (coolingSystem.MaxTdpConsumption.Value < motherboard.MotherboardCpu.CpuTdpConsumption.Value)
            throw new ExceededValueException("The tdp value is exceeded!");

        _computerBuilder.AddCpuCoolingSystem(coolingSystem);

        if (motherboard.MotherboardCpu.CpuCoreAmount.Value is not (4 or 6))
            throw new FailedToBuildComputerException("Failed to build computer!");

        _computerBuilder.AddMotherboard(motherboard);

        if (computerCase.CaseSize.Value < coolingSystem.CoolingSystemSize.Value + motherboard.MotherboardSize.Value)
            throw new FailedToBuildComputerException("Failed to build computer!");

        _computerBuilder.AddComputerCase(computerCase);

        _computerBuilder.AddHdd(hdd);
        _computerBuilder.AddSsd(ssd);
        _computerBuilder.AddGraphicsCard(videoCard);
        _computerBuilder.AddWiFiAdapter(wiFiAdapter);
        _computerBuilder.AddPowerUnit(powerUnit);
        _computerBuilder.AddRam(ram);
        return _computerBuilder.BuildComputer();
    }
}