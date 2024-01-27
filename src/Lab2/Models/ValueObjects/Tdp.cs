using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.ValueObjects;

public class Tdp
{
    public Tdp(int value)
    {
        if (value < 0)
            throw new ArgumentException("Tdp value must be greater than zero");
        Value = value;
    }

    public int Value { get; }
}