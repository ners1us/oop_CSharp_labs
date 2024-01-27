using System;

namespace Itmo.ObjectOrientedProgramming.Lab4.Exceptions;

public class NoFileFoundException : Exception
{
    public NoFileFoundException(string message)
        : base(message)
    {
    }

    public NoFileFoundException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    public NoFileFoundException()
    {
    }
}