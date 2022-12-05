using System.Collections.ObjectModel;

namespace MJE.Advent.SupplyStacks.Tests.Unit;

public class LiveTests {
    
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
    
    [Test]
    public void RunLiveTestOne()
    {
        var rearrangementProcedure = File.ReadAllLines("input.txt");
        
        var stackList = StackList();

        Crane.Operate(stackList, rearrangementProcedure);

        TestContext.Out.WriteLine(StackReporter.Report(stackList));
    }

}