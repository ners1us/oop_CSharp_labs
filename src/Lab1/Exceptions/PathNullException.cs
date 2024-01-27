namespace Itmo.ObjectOrientedProgramming.Lab1.Exceptions;

public class PathNullException : NullException
{
    public PathNullException(string message)
        : base(message)
    {
    }

    public PathNullException(string message, System.Exception innerException)
        : base(message, innerException)
    {
    }

    public PathNullException()
    {
    }
}