using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Exceptions;

public class DestroyedException : Exception
{
    protected DestroyedException()
    { }

    protected DestroyedException(string message)
        : base(message)
    { }

    protected DestroyedException(string message, Exception innerException)
        : base(message, innerException)
    { }
}