namespace Itmo.ObjectOrientedProgramming.Lab1.Models.CaseStrength.Cases;

public class CaseStrengthClassThree : CaseStrength
{
    private const int AsteroidCaseHealth = 200;
    private const int MeteoriteCaseHealth = 100;
    public CaseStrengthClassThree()
        : base(MeteoriteCaseHealth, AsteroidCaseHealth)
    {
    }
}