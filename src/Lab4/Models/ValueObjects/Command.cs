using System;

namespace Itmo.ObjectOrientedProgramming.Lab4.Models.ValueObjects;

public class Command
{
    public Command(string value)
    {
        if (string.IsNullOrEmpty(value))
            throw new ArgumentException("Command value shouldn't be null!");

        Value = value;
    }

    public string Value { get; }
}