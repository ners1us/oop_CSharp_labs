using System;

namespace Itmo.ObjectOrientedProgramming.Lab4.Models.ValueObjects;

public class Pathway
{
    public Pathway(string value)
    {
        if (string.IsNullOrEmpty(value))
            throw new ArgumentException("Pathway value shouldn't be null!");

        Value = value;
    }

    public string Value { get; }
}