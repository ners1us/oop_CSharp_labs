using Itmo.ObjectOrientedProgramming.Lab4.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab4.Models.CommandParser;

public interface IParser
{
    void ParseCommand(Command command);
}