using System.Collections.Generic;
using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab2.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.ComputerBody;

public class ComputerBody
{
    public ComputerBody(Size caseSize, ReadOnlyCollection<Size> supportedMotherBoardSizes, Size maxSupportedVideoCardSize)
    {
        CaseSize = caseSize;
        SupportedMotherBoardSizes = supportedMotherBoardSizes;
        MaxSupportedVideoCardSize = maxSupportedVideoCardSize;
    }

    public Size CaseSize { get; private set; }
    public Size MaxSupportedVideoCardSize { get; private set; }
    public ICollection<Size> SupportedMotherBoardSizes { get; private set; }
}