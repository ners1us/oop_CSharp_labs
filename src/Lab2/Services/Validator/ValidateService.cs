using Itmo.ObjectOrientedProgramming.Lab2.Entities.Computer;
using Itmo.ObjectOrientedProgramming.Lab2.Exceptions;
using Itmo.ObjectOrientedProgramming.Lab2.Models.CPUCoolingSystem;
using Itmo.ObjectOrientedProgramming.Lab2.Models.HDD;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Validator;

public static class ValidateService
{
    public static bool ValidateFinishedAssmebling(Computer computer)
    {
        if (computer is null)
            throw new NullException("The computer shouldn't be null!");

        switch (computer.HardDrive)
        {
            case null:
                CheckBuildWithHdd(computer);
                break;

            case not null:
                CheckBuildWithSsd(computer);
                break;
        }

        return true;
    }

    public static bool ValidateNewSupportingHddComponent(Computer computer, Hdd hdd)
    {
        if (computer is null)
            throw new NullException("The computer shouldn't be null!");

        if (hdd is null || computer.HardDrive is null)
            throw new NullException("The hdd shouldn't be null!");

        if (hdd.HddPowerConsumption.Value > computer.HardDrive.HddPowerConsumption.Value)
            return false;

        return true;
    }

    public static bool ValidateEnoughTdpForCoolingSystem(Warehouse.Warehouse warehouse, CoolingSystem? coolingSystem)
    {
        if (warehouse is null || coolingSystem is null)
            throw new NullException("Null value was found!");

        if (warehouse.CoolingSystems[1].MaxTdpConsumption.Value > coolingSystem.MaxTdpConsumption.Value || warehouse.CoolingSystems[0].MaxTdpConsumption.Value > coolingSystem.MaxTdpConsumption.Value)
            throw new NotEnoughTdpException("The tdp is not enough!");

        return true;
    }

    private static void CheckBuildWithHdd(Computer computer)
    {
        if (computer.Wifi is null || computer.Ssd is null || computer.RamMemory is null ||
            computer.Body is null || computer.VideoCard is null || computer.CpuCoolingSystem is null)

            throw new NotFinishedBuildException("The build is not finished!");
    }

    private static void CheckBuildWithSsd(Computer computer)
    {
        if (computer.Wifi is null || computer.RamMemory is null ||
            computer.Body is null || computer.VideoCard is null || computer.CpuCoolingSystem is null)

            throw new NotFinishedBuildException("The build is not finished!");
    }
}