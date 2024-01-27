using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.ValueObjects;

public class Frequency
{
    public Frequency(int value)
    {
        if (value < 0)
            throw new ArgumentException("Frequency value must be greater than zero");

        Value = value;
    }

    public int Value { get; }
}