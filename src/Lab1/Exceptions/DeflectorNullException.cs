namespace Itmo.ObjectOrientedProgramming.Lab1.Exceptions;

public class DeflectorNullException : NullException
{
    public DeflectorNullException(string message)
        : base(message)
    {
    }

    public DeflectorNullException()
    {
    }

    public DeflectorNullException(string message, System.Exception innerException)
        : base(message, innerException)
    {
    }
}