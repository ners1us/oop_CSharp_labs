using System;

namespace Itmo.ObjectOrientedProgramming.Lab4.Exceptions;

public class UnknownCommandException : Exception
{
    public UnknownCommandException(string message)
        : base(message)
    {
    }

    public UnknownCommandException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    public UnknownCommandException()
    {
    }
}