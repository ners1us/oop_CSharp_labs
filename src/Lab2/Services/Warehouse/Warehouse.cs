using System.Collections.Generic;
using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab2.Exceptions;
using Itmo.ObjectOrientedProgramming.Lab2.Models.BIOS;
using Itmo.ObjectOrientedProgramming.Lab2.Models.ComputerBody;
using Itmo.ObjectOrientedProgramming.Lab2.Models.CPU;
using Itmo.ObjectOrientedProgramming.Lab2.Models.CPUCoolingSystem;
using Itmo.ObjectOrientedProgramming.Lab2.Models.HDD;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Motherboard;
using Itmo.ObjectOrientedProgramming.Lab2.Models.PowerUnit;
using Itmo.ObjectOrientedProgramming.Lab2.Models.RAM;
using Itmo.ObjectOrientedProgramming.Lab2.Models.SSD;
using Itmo.ObjectOrientedProgramming.Lab2.Models.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab2.Models.VideoCard;
using Itmo.ObjectOrientedProgramming.Lab2.Models.WiFiAdapter;
using Itmo.ObjectOrientedProgramming.Lab2.Models.XMP;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Warehouse;

public class Warehouse
{
    public Warehouse()
    {
        InitializeCpus();

        if (Cpus == null)
            throw new NullException("Cpus shouldn't be null!");

        InitializeBios();

        if (BiosComponents is null)
            throw new NullException("Bios components shouldn't be null!");

        InitializeCoolingSystems();

        if (CoolingSystems is null)
            throw new NullException("Cooling systems shouldn't be null!");

        InitializeHdds();

        if (Hdds is null)
            throw new NullException("Cooling systems shouldn't be null!");

        InitializeMotherboards();

        if (Motherboards is null)
            throw new NullException("Motherboards shouldn't be null!");

        InitializePowerUnits();

        if (PowerUnits is null)
            throw new NullException("Power units shouldn't be null!");

        InitializeRams();

        if (Rams is null)
            throw new NullException("Rams shouldn't be null!");

        InitializeSsds();

        if (Ssds is null)
            throw new NullException("Power units shouldn't be null!");

        InitializeVideoCards();
        if (VideoCards is null)
            throw new NullException("Videocards shouldn't be null!");

        InitializeWifiAdapters();
        if (WiFiAdapters is null)
            throw new NullException("Wifi adapters shouldn't be null!");

        InitializeComputerBodies();
        if (ComputerBodies is null)
            throw new NullException("Computer bodies shouldn't be null!");
    }

    public ReadOnlyCollection<Bios> BiosComponents { get; private set; }
    public ReadOnlyCollection<ComputerBody> ComputerBodies { get; private set; }
    public ReadOnlyCollection<CpuWithInnerVideoCore> Cpus { get; private set; }
    public ReadOnlyCollection<CoolingSystem> CoolingSystems { get; private set; }
    public ReadOnlyCollection<Hdd> Hdds { get; private set; }
    public ReadOnlyCollection<Motherboard> Motherboards { get; private set; }
    public ReadOnlyCollection<PowerUnit> PowerUnits { get; private set; }
    public ReadOnlyCollection<Ram> Rams { get; private set; }
    public ReadOnlyCollection<Ssd> Ssds { get; private set; }
    public ReadOnlyCollection<VideoCard> VideoCards { get; private set; }
    public ReadOnlyCollection<WiFiAdapterWithBluetooth> WiFiAdapters { get; private set; }

    private void InitializeCpus()
    {
        var cpuOne = new Cpu(new Frequency(3600), new Amount(4), new Frequency(3600), new Tdp(60), new Watt(80));
        var cpuTwo = new Cpu(new Frequency(2400), new Amount(6), new Frequency(2800), new Tdp(50), new Watt(95));
        var firstGraphicCpu = new CpuWithInnerVideoCore(cpuOne);
        var secondGraphicCpu = new CpuWithInnerVideoCore(cpuTwo);
        Cpus = new ReadOnlyCollection<CpuWithInnerVideoCore>(new List<CpuWithInnerVideoCore> { firstGraphicCpu, secondGraphicCpu });
    }

    private void InitializeBios()
    {
        var firstSupportedCpus = new ReadOnlyCollection<ICpu>(new List<ICpu> { Cpus[0], Cpus[1] });
        var biosOne = new Bios(new Kind("UEFI"), new VersionName("2.5"), firstSupportedCpus);
        var secondSupportedCpus = new ReadOnlyCollection<ICpu>(new List<ICpu> { Cpus[1] });
        var biosTwo = new Bios(new Kind("Legacy"), new VersionName("1.0"), secondSupportedCpus);
        BiosComponents = new ReadOnlyCollection<Bios>(new List<Bios> { biosOne, biosTwo });
    }

    private void InitializeCoolingSystems()
    {
        var coolingSystemOne = new CoolingSystem(new Size(160), new Tdp(100), new ReadOnlyCollection<Socket>(new List<Socket> { new Socket("1151"), new Socket("1200") }));
        var coolingSystemTwo = new CoolingSystem(new Size(120), new Tdp(85), new ReadOnlyCollection<Socket>(new List<Socket> { new Socket("1151"), new Socket("1200") }));
        CoolingSystems = new ReadOnlyCollection<CoolingSystem>(new List<CoolingSystem> { coolingSystemOne, coolingSystemTwo });
    }

    private void InitializeHdds()
    {
        var hddOne = new Hdd(new Gigabytes(256), new Speed(7200), new Watt(10));
        var hddTwo = new Hdd(new Gigabytes(512), new Speed(5400), new Watt(8));
        Hdds = new ReadOnlyCollection<Hdd>(new List<Hdd> { hddOne, hddTwo });
    }

    private void InitializeMotherboards()
    {
        var motherboardOne = new Motherboard(Cpus[0], new Xmp(new Timings("16-18-18-36"), new Voltage(1.35), new Frequency(3200)), new Amount(4), new Size(200), BiosComponents[0], new Year(2021));
        var motherboardTwo = new Motherboard(Cpus[1], new Xmp(new Timings("15-17-17-35"), new Voltage(1.4), new Frequency(3600)), new Amount(4), new Size(150), BiosComponents[1], new Year(2022));
        Motherboards = new ReadOnlyCollection<Motherboard>(new List<Motherboard> { motherboardOne, motherboardTwo });
    }

    private void InitializePowerUnits()
    {
        var powerUnitOne = new PowerUnit(new Watt(400));
        var powerUnitTwo = new PowerUnit(new Watt(550));
        PowerUnits = new ReadOnlyCollection<PowerUnit>(new List<PowerUnit> { powerUnitOne, powerUnitTwo });
    }

    private void InitializeRams()
    {
        var ramOne = new Ram(new Gigabytes(16), new ReadOnlyCollection<Xmp>(new List<Xmp> { new Xmp(new Timings("16-18-18-36"), new Voltage(1.35), new Frequency(3200)) }), new Size(25), new VersionName("4.0"), new Watt(5));
        var ramTwo = new Ram(new Gigabytes(32), new ReadOnlyCollection<Xmp>(new List<Xmp> { new Xmp(new Timings("15-17-17-35"), new Voltage(1.4), new Frequency(3600)) }), new Size(36), new VersionName("4.0"), new Watt(8));
        Rams = new ReadOnlyCollection<Ram>(new List<Ram> { ramOne, ramTwo });
    }

    private void InitializeSsds()
    {
        var ssdOne = new Ssd("M.2", new Gigabytes(512), new Watt(4), new Speed(1850));
        var ssdTwo = new Ssd("2.5-inch SATA", new Gigabytes(1024), new Watt(6), new Speed(2340));
        Ssds = new ReadOnlyCollection<Ssd>(new List<Ssd> { ssdOne, ssdTwo });
    }

    private void InitializeComputerBodies()
    {
        var caseOne = new ComputerBody(new Size(415), new ReadOnlyCollection<Size>(new List<Size> { new Size(200), new Size(150) }), new Size(300));
        var caseTwo = new ComputerBody(new Size(300), new ReadOnlyCollection<Size>(new List<Size> { new Size(200), new Size(150) }),  new Size(400));
        ComputerBodies = new ReadOnlyCollection<ComputerBody>(new List<ComputerBody> { caseOne, caseTwo });
    }

    private void InitializeWifiAdapters()
    {
        var wifiAdapterOne = new WiFiAdapter(new VersionName("802.11ac"), new Watt(5));
        var wifiAdapterTwo = new WiFiAdapter(new VersionName("802.11ax"), new Watt(3));
        var firstWiFiAdapterWithBluetooth = new WiFiAdapterWithBluetooth(wifiAdapterOne);
        var secondWiFiAdapterWithBluetooth = new WiFiAdapterWithBluetooth(wifiAdapterTwo);
        WiFiAdapters = new ReadOnlyCollection<WiFiAdapterWithBluetooth>(new List<WiFiAdapterWithBluetooth> { firstWiFiAdapterWithBluetooth, secondWiFiAdapterWithBluetooth });
    }

    private void InitializeVideoCards()
    {
        var videoCardOne = new VideoCard(new Height(120), new Width(30), new Frequency(1500), new Watt(150));
        var videoCardTwo = new VideoCard(new Height(150), new Width(40), new Frequency(1800), new Watt(200));
        VideoCards = new ReadOnlyCollection<VideoCard>(new List<VideoCard> { videoCardOne, videoCardTwo });
    }
}
