using System;

namespace Itmo.ObjectOrientedProgramming.Lab3.Exceptions;

public class AlreadyReadMessageException : Exception
{
    public AlreadyReadMessageException(string message)
        : base(message)
    {
    }

    public AlreadyReadMessageException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    public AlreadyReadMessageException()
    {
    }
}