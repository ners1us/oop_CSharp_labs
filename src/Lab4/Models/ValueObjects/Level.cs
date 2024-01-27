using System;

namespace Itmo.ObjectOrientedProgramming.Lab4.Models.ValueObjects;

public class Level
{
    public Level(int value)
    {
        if (value < 0)
            throw new ArgumentException("Level value must be greater than zero");

        Value = value;
    }

    public int Value { get; }
}