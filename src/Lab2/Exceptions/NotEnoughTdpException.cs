using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.Exceptions;

public class NotEnoughTdpException : Exception
{
    public NotEnoughTdpException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    public NotEnoughTdpException(string message)
        : base(message)
    {
    }

    public NotEnoughTdpException()
    {
    }
}