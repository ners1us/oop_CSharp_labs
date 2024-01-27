using System.Collections.Generic;
using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Computer;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Computer.Builder;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Computer.Director;
using Itmo.ObjectOrientedProgramming.Lab2.Exceptions;
using Itmo.ObjectOrientedProgramming.Lab2.Models.ComputerBody;
using Itmo.ObjectOrientedProgramming.Lab2.Models.CPUCoolingSystem;
using Itmo.ObjectOrientedProgramming.Lab2.Models.HDD;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Motherboard;
using Itmo.ObjectOrientedProgramming.Lab2.Models.PowerUnit;
using Itmo.ObjectOrientedProgramming.Lab2.Models.RAM;
using Itmo.ObjectOrientedProgramming.Lab2.Models.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab2.Models.VideoCard;
using Itmo.ObjectOrientedProgramming.Lab2.Models.WiFiAdapter;
using Itmo.ObjectOrientedProgramming.Lab2.Services.Repository;
using Itmo.ObjectOrientedProgramming.Lab2.Services.Validator;
using Itmo.ObjectOrientedProgramming.Lab2.Services.Warehouse;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab2.Tests;

public class ThirdTestForSecondLab
{
    [Fact]
    public void AttemptAssemblingWithCompatibleCoolerButWithInsufficientPowerToDissipateTheHeatProducedByTheProcessMustBeMadeWithMandatoryCommentWhenTransferringOrderToTheSalesDepartmentTest()
    {
        // Arrange
        var builder = new ComputerBuilder();
        var warehouse = new Warehouse();
        var director = new Director(builder);
        var repository = new Repository(warehouse);
        Motherboard motherboard = repository.FindMotherboardByYear(new Year(2021));
        CoolingSystem coolingSystem = repository.FindCoolingSystemBySize(new Size(160));
        Hdd hdd = repository.FindHddBySpeed(new Speed(7200));
        VideoCard videoCard = repository.FindVideoCardByFrequency(new Frequency(1800));
        WiFiAdapterWithBluetooth wiFiAdapter = repository.FindWiFiAdapterByVersion(new VersionName("802.11ac"));
        PowerUnit powerUnit = repository.FindPowerUnitByWatt(new Watt(550));
        Ram ram = repository.FindRamByGigabytes(new Gigabytes(32));
        ComputerBody computerBody = repository.FindComputerBodyBySize(new Size(415));
        var newCoolingSystemComponent = new CoolingSystem(new Size(150), new Tdp(80), new ReadOnlyCollection<Socket>(new List<Socket> { new Socket("1151"), new Socket("1200") }));
        Computer computer = director.BuildCustomComputer(computerBody, newCoolingSystemComponent, motherboard, hdd, null, videoCard, wiFiAdapter, powerUnit, ram);

        // Assert & Act
        Assert.Throws<NotEnoughTdpException>(() => ValidateService.ValidateEnoughTdpForCoolingSystem(warehouse, computer.CpuCoolingSystem));
    }
}