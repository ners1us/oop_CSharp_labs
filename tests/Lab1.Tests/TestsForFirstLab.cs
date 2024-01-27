using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacle.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceship.Spaceships;
using Itmo.ObjectOrientedProgramming.Lab1.Exceptions;
using Itmo.ObjectOrientedProgramming.Lab1.Models.CaseStrength.Cases;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Deflector.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Habitat.Habitats;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Route;
using Itmo.ObjectOrientedProgramming.Lab1.Services;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class TestsForFirstLab
{
    public static IEnumerable<object[]> BaseAugurShuttleTest()
    {
        yield return new object[] { new Augur(70, new DeflectorClassThree(false), Augur.CreateAugurEngines(), new CaseStrengthClassThree()),  new PleasureShuttle(40, null, PleasureShuttle.CreateShuttleEngines(), new CaseStrengthClassOne()) };
    }

    public static IEnumerable<object[]> BaseVaclasOneAndVaclasTwoTest()
    {
        yield return new object[] { new Vaclas(1200, new DeflectorClassOne(false), Vaclas.CreateVaclasEngines(), new CaseStrengthClassTwo()), new Vaclas(1200, new DeflectorClassOne(false), Vaclas.CreateVaclasEngines(), new CaseStrengthClassTwo()) };
    }

    public static IEnumerable<object[]> BaseVaclasAndAugurAndMeridianTest()
    {
        yield return new object[] { new Vaclas(700, new DeflectorClassOne(false), Vaclas.CreateVaclasEngines(), new CaseStrengthClassTwo()), new Augur(700, new DeflectorClassThree(false), Augur.CreateAugurEngines(), new CaseStrengthClassThree()), new Meridian(1500, new DeflectorClassTwo(false), Meridian.CreateMeridianEngines(), new CaseStrengthClassTwo()) };
    }

    [Theory]
    [MemberData(nameof(BaseAugurShuttleTest))]
    public void SendShuttleAndAugurToTheIncreasedDensityNebulaExpectNoWarpEngineExceptionAndNotEnoughRangeToWarpTest(Augur? augur, PleasureShuttle? shuttle)
    {
        if (augur is null || shuttle is null)
        {
            Assert.Fail("Found null spaceship!");
            return;
        }

        // Arrange
        var route = new Route(new NebulaIncreasedDensity(new Meteorite(20), new SmallAsteroid(10), new CosmoWhales(0)), 1000);

        // Assert & Act
        Assert.Throws<PathIsNotEndedException>(() => augur.ProcessRoute(route, augur));
        Assert.Throws<PathIsNotEndedException>(() => shuttle.ProcessRoute(route, shuttle));
    }

    [Theory]
    [MemberData(nameof(BaseVaclasOneAndVaclasTwoTest))]
    public void SendVaclasAndVaclasWithFotonDeflectorDeadCrewAndEndedPathTest(Vaclas? vaclas1, Vaclas? vaclas2)
    {
        if (vaclas1 is null || vaclas2 is null)
        {
            Assert.Fail("Found null spaceship!");
            return;
        }

        // Arrange
        var route = new Route(new NebulaIncreasedDensity(new Meteorite(15), new SmallAsteroid(5), new CosmoWhales(0)), 200);

        // Act
        vaclas1.Deflector?.ChangeFotonModification();
        ClashWithObstacle.DeflectFotonFlash(vaclas1.Deflector, vaclas1);
        ClashWithObstacle.DeflectFotonFlash(vaclas1.Deflector, vaclas1);
        ClashWithObstacle.DeflectFotonFlash(vaclas1.Deflector, vaclas1);

        // Assert
        Assert.Throws<CrewDeadException>(() => ClashWithObstacle.DeflectFotonFlash(vaclas1.Deflector, vaclas1));
        Assert.True(vaclas2.ProcessRoute(route, vaclas2));
    }

    [Theory]
    [MemberData(nameof(BaseVaclasAndAugurAndMeridianTest))]
    public void SendAugurAndVaclasAndMeridianToNitrineNebulaDestroyFirstSecondLostShieldsThirdIsOkTest(Vaclas? vaclas, Augur? augur, Meridian? meridian)
    {
        if (vaclas is null || augur is null || meridian is null)
        {
            Assert.Fail("Found null spaceship!");
            return;
        }

        // Arrange
        var route = new Route(new NitrineNebula(new Meteorite(2), new SmallAsteroid(40), new CosmoWhales(1)), 200);

        // Assert & Act
        Assert.Throws<ShipDestroyedException>(() => ClashWithObstacle.ClashShipWithMeteorite(vaclas, route, new Meteorite(0)));
        Assert.Throws<DeflectorDestroyedException>(() => ClashWithObstacle.ClashDeflectorWithAsteroid(augur, route, new SmallAsteroid(0)));
        Assert.True(meridian.ProcessRoute(route, meridian));
    }

    [Fact]
    public void SendShuttleOrVaclasToSpaceChooseShuttleTest()
    {
        // Arrange
        var pleasureShuttle = new PleasureShuttle(200, null, PleasureShuttle.CreateShuttleEngines(), new CaseStrengthClassOne());
        var vaclas = new Vaclas(200, new DeflectorClassOne(false), Vaclas.CreateVaclasEngines(), new CaseStrengthClassTwo());

        // Assert & Act
        Assert.Equal(SpaceshipSelection.SelectLesserCostFuelSpaceship(pleasureShuttle, vaclas), vaclas);
    }

    [Fact]
    public void SelectAugurOrStellaAndSendToIncreasedDensityNebulaTest()
    {
        // Arrange
        var augur = new Augur(600,  new DeflectorClassThree(false), Augur.CreateAugurEngines(), new CaseStrengthClassThree());
        var stella = new Stella(600, new DeflectorClassOne(false), Stella.CreateStellaEngines(), new CaseStrengthClassOne());
        var route = new Route(new NebulaIncreasedDensity(new Meteorite(0), new SmallAsteroid(0), new CosmoWhales(0)), 750);

        // Assert & Act
        Assert.Equal(SpaceshipSelection.WhichIsFurtherSpaceship(augur, stella, route), stella);
    }

    [Fact]
    public void SelectShuttleOrVaclasToNitrineNebulaTest()
    {
        // Arrange
        var pleasureShuttle = new PleasureShuttle(700, null, PleasureShuttle.CreateShuttleEngines(), new CaseStrengthClassOne());
        var vaclas = new Vaclas(500, new DeflectorClassOne(false), Vaclas.CreateVaclasEngines(), new CaseStrengthClassTwo());
        var route = new Route(new NitrineNebula(new Meteorite(15), new SmallAsteroid(2), new CosmoWhales(0)), 750);

        // Assert & Act
        Assert.Equal(SpaceshipSelection.SelectBetterSpaceship(pleasureShuttle, vaclas, route), vaclas);
    }

    [Fact]
    public void SendAugurToThreeDifferentRoutesAndEndItInTheLastOneTest()
    {
        // Arrange
        var augur = new Augur(1500, new DeflectorClassThree(false), Augur.CreateAugurEngines(), new CaseStrengthClassThree());
        var firstRoute = new Route(new NitrineNebula(new Meteorite(0), new SmallAsteroid(0), new CosmoWhales(0)), 200);
        var secondRoute = new Route(new NebulaIncreasedDensity(new Meteorite(8), new SmallAsteroid(3), new CosmoWhales(0)), 250);
        var thirdRoute = new Route(new Space(new Meteorite(10), new SmallAsteroid(3), new CosmoWhales(0)), 250);

        // Assert
        Assert.True(augur.ProcessRoute(firstRoute, augur));

        // Act
        ClashWithObstacle.ClashDeflectorWithAsteroid(augur, secondRoute, new SmallAsteroid(0));

        // Assert
        Assert.True(augur.ProcessRoute(secondRoute, augur));

        // Assert & Act
        Assert.Throws<DeflectorDestroyedException>(() => ClashWithObstacle.ClashDeflectorWithMeteorite(augur, thirdRoute, new Meteorite(0)));
    }
}