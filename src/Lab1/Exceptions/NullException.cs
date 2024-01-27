using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Exceptions;

public class NullException : Exception
{
    public NullException()
    { }

    public NullException(string message)
        : base(message)
    { }

    public NullException(string message, Exception innerException)
        : base(message, innerException)
    { }
}