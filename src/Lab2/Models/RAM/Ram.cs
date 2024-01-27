using System.Collections.Generic;
using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab2.Models.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab2.Models.XMP;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.RAM;

public class Ram
{
    public Ram(Gigabytes availableMemoryAmount, ReadOnlyCollection<Xmp> availableXmpProfiles, Size ramSize, VersionName ddrVersionName, Watt ramPowerConsumption)
    {
        AvailableMemoryAmount = availableMemoryAmount;
        AvailableXmpProfiles = availableXmpProfiles;
        RamSize = ramSize;
        DdrVersionName = ddrVersionName;
        RamPowerConsumption = ramPowerConsumption;
    }

    public Gigabytes AvailableMemoryAmount { get; private set; }
    public ICollection<Xmp> AvailableXmpProfiles { get; private set; }
    public Size RamSize { get; private set; }
    public VersionName DdrVersionName { get; private set; }
    public Watt RamPowerConsumption { get; private set; }
}