using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Exceptions;

public class PathIsNotEndedException : Exception
{
    public PathIsNotEndedException(string message)
        : base(message)
    {
    }

    public PathIsNotEndedException(string message, System.Exception innerException)
        : base(message, innerException)
    {
    }

    public PathIsNotEndedException()
    {
    }
}