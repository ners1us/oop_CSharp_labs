using Itmo.ObjectOrientedProgramming.Lab2.Models.BIOS;
using Itmo.ObjectOrientedProgramming.Lab2.Models.CPU;
using Itmo.ObjectOrientedProgramming.Lab2.Models.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab2.Models.XMP;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Motherboard;

public class Motherboard
{
    public Motherboard(ICpu motherboardCpu, Xmp xmpChipset, Amount ramSlotsAmount, Size motherboardSize, Bios motherboardBios, Year yearOfRelease)
    {
        MotherboardCpu = motherboardCpu;
        XmpChipset = xmpChipset;
        RamSlotsAmount = ramSlotsAmount;
        MotherboardSize = motherboardSize;
        MotherboardBios = motherboardBios;
        YearOfRelease = yearOfRelease;
    }

    public ICpu MotherboardCpu { get; private set; }
    public Xmp XmpChipset { get; private set; }
    public Amount RamSlotsAmount { get; private set; }
    public Size MotherboardSize { get; private set; }
    public Bios MotherboardBios { get; private set; }
    public Year YearOfRelease { get; private set; }
}