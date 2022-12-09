namespace MJE.Advent.TreeTopHouse.Tests.Unit;

public class LiveTests
{

    private string TreeMap()
    {
        return File.ReadAllText("input.txt");
    }

    [Test]
    public void LiveTest_One()
    {
        var ls = TreeMap();

        var (visibleTrees,highestScenicScore) = TreeComparer.CalculateVisibleTrees(ls);

        Console.WriteLine($"Visible trees is {visibleTrees}\r\nHighest scenic score is {highestScenicScore}");

    }
    
}