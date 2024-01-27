using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models.CPU;
using Itmo.ObjectOrientedProgramming.Lab2.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.BIOS;

public class Bios
{
    public Bios(Kind biosKind, VersionName biosVersionName, ICollection<ICpu> supportedCpuList)
    {
        BiosKind = biosKind;
        BiosVersionName = biosVersionName;
        SupportedCpuList = supportedCpuList;
    }

    public Kind BiosKind { get; private set; }
    public VersionName BiosVersionName { get; private set; }
    public ICollection<ICpu> SupportedCpuList { get; private set; }
}