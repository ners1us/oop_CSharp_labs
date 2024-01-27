using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.Exceptions;

public class FailedToBuildComputerException : Exception
{
    public FailedToBuildComputerException(string message)
        : base(message)
    {
    }

    public FailedToBuildComputerException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    public FailedToBuildComputerException()
    {
    }
}