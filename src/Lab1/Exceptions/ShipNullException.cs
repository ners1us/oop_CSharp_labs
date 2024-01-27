namespace Itmo.ObjectOrientedProgramming.Lab1.Exceptions;

public class ShipNullException : NullException
{
    public ShipNullException(string message)
        : base(message)
    {
    }

    public ShipNullException()
    {
    }

    public ShipNullException(string message, System.Exception innerException)
        : base(message, innerException)
    {
    }
}