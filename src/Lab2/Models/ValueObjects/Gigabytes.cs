using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.ValueObjects;

public class Gigabytes
{
    public Gigabytes(int value)
    {
        if (value < 0)
            throw new ArgumentException("Gigabytes value must be greater than zero");

        Value = value;
    }

    public int Value { get; }
}