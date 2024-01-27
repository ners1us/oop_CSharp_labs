namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Deflector.Deflectors;

public class DeflectorClassOne : Deflector
{
    private const int DeflectorClassOneMeteoriteHealth = 20;
    private const int DeflectorClassOneAsteroidHealth = 20;
    private const int DeflectorClassOneCosmoWhaleHealth = 0;
    public DeflectorClassOne(bool fotonModificationFlag)
        : base(fotonModificationFlag, DeflectorClassOneMeteoriteHealth, DeflectorClassOneAsteroidHealth, DeflectorClassOneCosmoWhaleHealth)
    {
    }
}