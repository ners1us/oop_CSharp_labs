using Itmo.ObjectOrientedProgramming.Lab1.Exceptions;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Deflector;

public abstract class Deflector
{
    protected Deflector(bool fotonModification, int meteoriteHealth, int asteroidHealth, int cosmoWhaleHealth)
    {
        if (meteoriteHealth < 0 || asteroidHealth < 0 || cosmoWhaleHealth < 0)
            throw new NegativeValueException("Values shouldn't be negative!");

        FotonModification = fotonModification;
        MeteoriteHealth = meteoriteHealth;
        AsteroidHealth = asteroidHealth;
        CosmoWhaleHealth = cosmoWhaleHealth;
    }

    public int CosmoWhaleHealth { get; private set; }
    public int AsteroidHealth { get; private set; }
    public int MeteoriteHealth { get; private set; }
    public bool FotonModification { get; private set; }
    public int FlashHealth { get; private set; } = 3;

    public bool ChangeFotonModification()
    {
        return !FotonModification;
    }

    public void GetMeteoriteDamageFromObstacle(int damage)
    {
        MeteoriteHealth -= damage;

        ValidateHealthValue(MeteoriteHealth);
    }

    public void GetAsteroidDamageFromObstacle(int damage)
    {
        AsteroidHealth -= damage;

        ValidateHealthValue(AsteroidHealth);
    }

    public void GetFotonDamageFromObstacle()
    {
        FlashHealth -= 1;
    }

    private static void ValidateHealthValue(int health)
    {
        if (health < 0) throw new NegativeValueException("Value shouldn't be negative!");
    }
}