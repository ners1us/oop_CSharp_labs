using System;
using Itmo.ObjectOrientedProgramming.Lab4.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab4.Models.CommandHandler;

public class DefaultHandle : BaseCommandHandle
{
    public override void Handle(Command command)
    {
        Console.WriteLine("Unknown command");
    }
}