using Itmo.ObjectOrientedProgramming.Lab2.Entities.Computer.Builder;
using Itmo.ObjectOrientedProgramming.Lab2.Models.HDD;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Computer.Director;

public class DirectorRebuilder
{
    private readonly IComputerBuilder _computerBuilder;
    private readonly Computer _currentComputer;

    public DirectorRebuilder(IComputerBuilder computerBuilder, Computer currentComputer)
    {
        _computerBuilder = computerBuilder;
        _currentComputer = currentComputer;
    }

    public Computer ChangeHdd(Hdd? newHdd)
    {
        var newComputer = new Computer(
            _currentComputer.Body,
            _currentComputer.CpuCoolingSystem,
            _currentComputer.HardDrive,
            _currentComputer.Motherboard,
            _currentComputer.RamMemory,
            _currentComputer.Ssd,
            _currentComputer.VideoCard,
            _currentComputer.Wifi,
            _currentComputer.ComputerPowerUnit);

        _computerBuilder.AddHdd(newHdd);

        return newComputer;
    }
}