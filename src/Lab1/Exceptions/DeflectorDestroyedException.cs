namespace Itmo.ObjectOrientedProgramming.Lab1.Exceptions;

public class DeflectorDestroyedException : DestroyedException
{
    public DeflectorDestroyedException(string message)
        : base(message)
    {
    }

    public DeflectorDestroyedException()
    {
    }

    public DeflectorDestroyedException(string message, System.Exception innerException)
        : base(message, innerException)
    {
    }
}