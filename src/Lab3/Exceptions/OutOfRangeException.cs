using System;

namespace Itmo.ObjectOrientedProgramming.Lab3.Exceptions;

public class OutOfRangeException : Exception
{
    public OutOfRangeException(string message)
        : base(message)
    {
    }

    public OutOfRangeException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    public OutOfRangeException()
    {
    }
}