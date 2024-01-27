using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Exceptions;

public class CrewDeadException : Exception
{
    public CrewDeadException()
    { }

    public CrewDeadException(string message)
        : base(message)
    { }

    public CrewDeadException(string message, Exception innerException)
        : base(message, innerException)
    { }
}