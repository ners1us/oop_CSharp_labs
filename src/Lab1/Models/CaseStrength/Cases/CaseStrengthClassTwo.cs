namespace Itmo.ObjectOrientedProgramming.Lab1.Models.CaseStrength.Cases;

public class CaseStrengthClassTwo : CaseStrength
{
    private const int AsteroidCaseHealth = 50;
    private const int MeteoriteCaseHealth = 40;
    public CaseStrengthClassTwo()
        : base(MeteoriteCaseHealth, AsteroidCaseHealth)
    {
    }
}