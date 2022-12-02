namespace MJE.Advent.CalorieCounting.Tests.Unit;

public static class CalorieQueryRunner
{
    public static (int index, int value) Run(string numericList)
    {

        var aggregatedBlocks = numericList
            .Split("\r\n\r\n", StringSplitOptions.RemoveEmptyEntries)
            .Select(block => block.Split("\r\n"))
            .Select(x => x.Select(int.Parse).Sum()).ToArray();

        var aggregatedBlockByIndex = new Dictionary<int, int>();

        for (var i = 0; i < aggregatedBlocks.Length; i++)
        {
            aggregatedBlockByIndex.Add(i+1, aggregatedBlocks[i]);
        }

        var ret = aggregatedBlockByIndex.MaxBy(x => x.Value);
        
        return (ret.Key, ret.Value);
    }
}