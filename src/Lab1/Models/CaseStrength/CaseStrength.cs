using Itmo.ObjectOrientedProgramming.Lab1.Exceptions;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.CaseStrength;

public abstract class CaseStrength
{
    protected CaseStrength(int meteoriteHealth, int asteroidHealth)
    {
        if (meteoriteHealth < 0 || asteroidHealth < 0)
            throw new NegativeValueException("Values shouldn't be negative!");

        MeteoriteHealth = meteoriteHealth;
        AsteroidHealth = asteroidHealth;
    }

    public int MeteoriteHealth { get; private set; }
    public int AsteroidHealth { get; private set; }

    public void GetMeteoriteDamageFromObstacle(int damage)
    {
        MeteoriteHealth -= damage;

        if (MeteoriteHealth < 0) throw new NegativeValueException("Value shouldn't be negative!");
    }
}