using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.ValueObjects;

public class Width
{
    public Width(int value)
    {
        if (value < 0)
            throw new ArgumentException("Width value must be greater than zero");

        Value = value;
    }

    public int Value { get; }
}