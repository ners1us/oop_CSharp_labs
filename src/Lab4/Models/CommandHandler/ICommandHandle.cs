using Itmo.ObjectOrientedProgramming.Lab4.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab4.Models.CommandHandler;

public interface ICommandHandle
{
    ICommandHandle SetNext(ICommandHandle handler);
    void Handle(Command command);
}