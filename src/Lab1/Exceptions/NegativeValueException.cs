using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Exceptions;

public class NegativeValueException : Exception
{
    public NegativeValueException(string message)
        : base(message)
    {
    }

    public NegativeValueException()
    {
    }

    public NegativeValueException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}