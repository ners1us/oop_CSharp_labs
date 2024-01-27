using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.ValueObjects;

public class Speed
{
    public Speed(int value)
    {
        if (value < 0)
            throw new ArgumentException("Speed value must be greater than zero");

        Value = value;
    }

    public int Value { get; }
}