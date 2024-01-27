using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.ValueObjects;

public class Size
{
    public Size(int value)
    {
        if (value < 0)
            throw new ArgumentException("Size value must be greater than zero");

        Value = value;
    }

    public int Value { get; }
}