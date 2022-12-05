using System.Collections.ObjectModel;

namespace MJE.Advent.SupplyStacks.Tests.Unit;

public class CraneTests
{
    private static List<Stack<char>> StackList()
    {
        var ret = new List<Stack<char>>()
        {
            new(new Collection<char>() { 'N', 'Z' }.Reverse()),
            new(new Collection<char>() { 'D', 'C', 'M' }.Reverse()),
            new(new Collection<char>() { 'P' }.Reverse()),
        };

        return ret;
    }

    [Test]
    public void CrateMover9000Tests()
    {

        var rearrangementProcedure = new[]
        {
            "move 1 from 2 to 1",
            "move 3 from 1 to 3",
            "move 2 from 2 to 1",
            "move 1 from 1 to 2"
        };

        var stackList = StackList();

        new CrateMover9000().Operate(stackList, rearrangementProcedure);

        Assert.That(StackReporter.Report(stackList), Is.EqualTo("CMZ"));
    }
    
    [Test]
    public void CrateMover9001Tests()
    {

        var rearrangementProcedure = new[]
        {
            "move 1 from 2 to 1",
            "move 3 from 1 to 3",
            "move 2 from 2 to 1",
            "move 1 from 1 to 2"
        };

        var stackList = StackList();

        new CrateMover9001().Operate(stackList, rearrangementProcedure);

        Assert.That(StackReporter.Report(stackList), Is.EqualTo("MCD"));
    }
}