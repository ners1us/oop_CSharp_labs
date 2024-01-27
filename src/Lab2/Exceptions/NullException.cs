using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.Exceptions;

public class NullException : ArgumentNullException
{
    public NullException(string message)
        : base(message)
    {
    }

    public NullException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    public NullException()
    {
    }
}