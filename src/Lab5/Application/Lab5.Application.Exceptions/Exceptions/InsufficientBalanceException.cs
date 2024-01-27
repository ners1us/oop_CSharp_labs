namespace Lab5.Application.Exceptions;

public class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    public InsufficientBalanceException(string message)
        : base(message)
    {
    }

    public InsufficientBalanceException()
    {
    }
}