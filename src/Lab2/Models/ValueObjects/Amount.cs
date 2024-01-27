using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.ValueObjects;

public class Amount
{
    public Amount(int value)
    {
        if (value < 0)
            throw new ArgumentException("Amount value must be greater than zero");

        Value = value;
    }

    public int Value { get; }
}