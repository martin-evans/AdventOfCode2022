namespace MJE.Advent.RopeBridge.Tests.Unit;

public class MotionAnalyserTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var input = @"R 4
U 4
L 3
D 1
R 4
D 1
L 5
R 2";
        
        var positions = MotionAnalyser.CalculateVisitedPositions(input);
        
        Assert.That(positions, Is.EqualTo(13));

    }
}