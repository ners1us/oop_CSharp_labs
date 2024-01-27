using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.Exceptions;

public class ExceededValueException : Exception
{
    public ExceededValueException(string message)
        : base(message)
    {
    }

    public ExceededValueException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    public ExceededValueException()
    {
    }
}