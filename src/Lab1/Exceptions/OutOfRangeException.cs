using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Exceptions;

public class OutOfRangeException : Exception
{
    public OutOfRangeException(string message)
        : base(message)
    {
    }

    public OutOfRangeException()
    {
    }

    public OutOfRangeException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}