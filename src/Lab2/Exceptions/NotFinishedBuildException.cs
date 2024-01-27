using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.Exceptions;

public class NotFinishedBuildException : Exception
{
    public NotFinishedBuildException(string message)
        : base(message)
    {
    }

    public NotFinishedBuildException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    public NotFinishedBuildException()
    {
    }
}