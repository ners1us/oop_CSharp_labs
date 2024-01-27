using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.ValueObjects;

public class Voltage
{
    public Voltage(double value)
    {
        if (value < 0)
            throw new ArgumentException("Voltage value must be greater than zero");

        Value = value;
    }

    public double Value { get; }
}