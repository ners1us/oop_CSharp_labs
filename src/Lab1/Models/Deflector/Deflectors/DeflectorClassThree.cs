namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Deflector.Deflectors;

public class DeflectorClassThree : Deflector
{
    private const int DeflectorClassOneMeteoriteHealth = 200;
    private const int DeflectorClassOneAsteroidHealth = 400;
    private const int DeflectorClassOneCosmoWhaleHealth = 200;
    public DeflectorClassThree(bool fotonModificationFlag)
        : base(fotonModificationFlag, DeflectorClassOneMeteoriteHealth, DeflectorClassOneAsteroidHealth, DeflectorClassOneCosmoWhaleHealth)
    {
    }
}