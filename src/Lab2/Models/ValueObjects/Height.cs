using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.ValueObjects;

public class Height
{
    public Height(int value)
    {
        if (value < 0)
            throw new ArgumentException("Height value must be greater than zero");

        Value = value;
    }

    public int Value { get; }
}