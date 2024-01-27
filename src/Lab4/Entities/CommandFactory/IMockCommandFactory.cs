using Itmo.ObjectOrientedProgramming.Lab4.Models.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.CommandFactory;

public interface IMockCommandFactory
{
    ICommand Create(Text action, string[] parts);
}