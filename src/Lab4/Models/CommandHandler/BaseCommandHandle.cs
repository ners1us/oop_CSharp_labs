using Itmo.ObjectOrientedProgramming.Lab4.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab4.Models.CommandHandler;

public abstract class BaseCommandHandle : ICommandHandle
{
    private ICommandHandle? _nextHandler;

    public ICommandHandle SetNext(ICommandHandle handler)
    {
        _nextHandler = handler;
        return _nextHandler;
    }

    public abstract void Handle(Command command);

    protected void PassToNextHandler(Command command)
    {
        _nextHandler?.Handle(command);
    }
}
