using System;
using Itmo.ObjectOrientedProgramming.Lab3.Exceptions;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

public class Level
{
    private const int LeftLevelBorder = 1;
    private const int RightLevelBorder = 3;
    private const int BorderForPositiveValues = 0;
    public Level(int value)
    {
        Value = value switch
        {
            < BorderForPositiveValues => throw new ArgumentException("Tdp value must be greater than zero"),
            < LeftLevelBorder or > RightLevelBorder => throw new OutOfRangeException("Level value is out of range!"),
            _ => value,
        };
    }

    public int Value { get; }
}