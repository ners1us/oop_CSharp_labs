using Itmo.ObjectOrientedProgramming.Lab2.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.XMP;

public class Xmp
{
    public Xmp(Timings xmpTimings, Voltage xmpVoltage, Frequency xmpFrequency)
    {
        XmpTimings = xmpTimings;
        XmpVoltage = xmpVoltage;
        XmpFrequency = xmpFrequency;
    }

    public Timings XmpTimings { get; private set; }
    public Voltage XmpVoltage { get; private set; }
    public Frequency XmpFrequency { get; private set; }
}