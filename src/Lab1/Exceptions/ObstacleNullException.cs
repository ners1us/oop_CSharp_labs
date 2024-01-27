namespace Itmo.ObjectOrientedProgramming.Lab1.Exceptions;

public class ObstacleNullException : NullException
{
    public ObstacleNullException(string message)
        : base(message)
    {
    }

    public ObstacleNullException()
    {
    }

    public ObstacleNullException(string message, System.Exception innerException)
        : base(message, innerException)
    {
    }
}