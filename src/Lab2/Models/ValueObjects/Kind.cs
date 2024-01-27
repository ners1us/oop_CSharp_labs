using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.ValueObjects;

public class Kind
{
    public Kind(string value)
    {
        if (string.IsNullOrEmpty(value))
            throw new ArgumentException("Type value shouldn't be null!");

        Value = value;
    }

    public string Value { get; }
}