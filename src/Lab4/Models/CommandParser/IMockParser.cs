using System;
using Itmo.ObjectOrientedProgramming.Lab4.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab4.Models.CommandParser;

public interface IMockParser
{
    Type? ParseCommand(Command command);
}