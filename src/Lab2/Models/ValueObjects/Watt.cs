using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.ValueObjects;

public class Watt
{
    public Watt(int value)
    {
        if (value < 0)
            throw new ArgumentException("Watt value must be greater than zero");

        Value = value;
    }

    public int Value { get; }
}