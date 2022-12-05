namespace MJE.Advent.SupplyStacks.Tests.Unit;

public static class StackReporter
{
    public static string Report(IEnumerable<Stack<char>> stackList)
    {
        var topCrates = stackList.Select(x => x.Peek()).ToArray();

        return string.Join("", topCrates);
    }
}