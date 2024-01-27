namespace Itmo.ObjectOrientedProgramming.Lab1.Exceptions;

public class ShipDestroyedException : DestroyedException
{
    public ShipDestroyedException(string message)
        : base(message)
    {
    }

    public ShipDestroyedException()
    {
    }

    public ShipDestroyedException(string message, System.Exception innerException)
        : base(message, innerException)
    {
    }
}