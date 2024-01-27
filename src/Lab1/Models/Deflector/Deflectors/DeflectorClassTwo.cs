namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Deflector.Deflectors;

public class DeflectorClassTwo : Deflector
{
    private const int DeflectorClassOneMeteoriteHealth = 60;
    private const int DeflectorClassOneAsteroidHealth = 100;
    private const int DeflectorClassOneCosmoWhaleHealth = 0;
    public DeflectorClassTwo(bool fotonModificationFlag)
        : base(fotonModificationFlag, DeflectorClassOneMeteoriteHealth, DeflectorClassOneAsteroidHealth, DeflectorClassOneCosmoWhaleHealth)
    {
    }
}