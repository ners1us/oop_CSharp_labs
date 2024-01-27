namespace Itmo.ObjectOrientedProgramming.Lab1.Models.CaseStrength.Cases;

public class CaseStrengthClassOne : CaseStrength
{
    private const int AsteroidCaseHealth = 10;
    private const int MeteoriteCaseHealth = 0;
    public CaseStrengthClassOne()
        : base(MeteoriteCaseHealth, AsteroidCaseHealth)
    {
    }
}