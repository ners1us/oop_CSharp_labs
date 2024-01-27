using System;

namespace Itmo.ObjectOrientedProgramming.Lab3.Exceptions;

public class NotEqualLevelImportanceException : Exception
{
    public NotEqualLevelImportanceException(string message)
        : base(message)
    {
    }

    public NotEqualLevelImportanceException()
    {
    }

    public NotEqualLevelImportanceException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}