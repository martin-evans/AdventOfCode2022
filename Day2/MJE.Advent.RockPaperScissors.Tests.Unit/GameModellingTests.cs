namespace MJE.Advent.RockPaperScissors.Tests.Unit;

public class GameModellingTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void OpponentShapeSelectedTests()
    {
        var a = (int)OpponentShapeSelected.A;
        Assert.That(a, Is.EqualTo(1));
        
        var b = (int)OpponentShapeSelected.B;
        Assert.That(b, Is.EqualTo(2));

        var c = (int)OpponentShapeSelected.C;
        Assert.That(c, Is.EqualTo(3));

    }
    
    [Test]
    public void PlayerShapeSelectedTests()
    {
        var a = (int)PlayerShapeSelected.X;
        Assert.That(a, Is.EqualTo(1));
        
        var b = (int)PlayerShapeSelected.Y;
        Assert.That(b, Is.EqualTo(2));

        var c = (int)PlayerShapeSelected.Z;
        Assert.That(c, Is.EqualTo(3));

    }
    
    
    
    
}

public enum OpponentShapeSelected
{
    /// <summary>
    /// Rock
    /// </summary>
    A = 1,
    /// <summary>
    /// Paper
    /// </summary>
    B = 2,
    /// <summary>
    /// Scissors
    /// </summary>
    C = 3
}

public enum PlayerShapeSelected
{
    /// <summary>
    /// Rock
    /// </summary>
    X = 1,
    /// <summary>
    /// Paper
    /// </summary>
    Y = 2,
    /// <summary>
    /// Scissors
    /// </summary>
    Z = 3
}