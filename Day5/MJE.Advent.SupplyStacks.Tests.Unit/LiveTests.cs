using System.Collections.ObjectModel;

namespace MJE.Advent.SupplyStacks.Tests.Unit;

public class LiveTests
{

    private string[] _rearrangementProcedure = null!;
    private static List<Stack<char>> StackList()
    {
        var ret = new List<Stack<char>>()
        {
            new(new Collection<char>() { 'S', 'T','H','F','W','R' }),
            new(new Collection<char>() { 'S', 'G','D','Q','W' }),
            new(new Collection<char>() { 'B', 'T','W' }),
            new(new Collection<char>() { 'D', 'R','W','T','N','Q','Z','J' }),
            new(new Collection<char>() { 'F', 'B','H','G','L','V','T','Z' }),
            new(new Collection<char>() { 'L', 'P','T','C','V','B','S','G' }),
            new(new Collection<char>() { 'Z', 'B','R','T','W','G','P' }),
            new(new Collection<char>() { 'N', 'G','M','T','C','J','R' }),
            new(new Collection<char>() { 'L', 'G','B','W' }),
        };

        return ret;
    }

    [OneTimeSetUp]
    public void LoadData()
    {
        _rearrangementProcedure = File.ReadAllLines("input.txt");
    }
    
    [Test]
    public void RunLiveCrateMover9000Test()
    {
        
        var stackList = StackList();

        new CrateMover9000().Operate(stackList, _rearrangementProcedure);

        TestContext.Out.WriteLine(StackReporter.Report(stackList));
    }
    
    [Test]
    public void RunLiveCrateMover9001Test()
    {
        var stackList = StackList();

        new CrateMover9001().Operate(stackList, _rearrangementProcedure);

        TestContext.Out.WriteLine(StackReporter.Report(stackList));
    }

}