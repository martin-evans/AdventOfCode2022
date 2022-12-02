namespace MJE.Advent.CalorieCounting.Tests.Unit;

public static class CalorieQueryRunner
{
    public static QueryResult[] Run(string numericList, int elements)
    {

        var aggregatedBlocks = numericList
            .Split("\r\n\r\n", StringSplitOptions.RemoveEmptyEntries)
            .Select(block => block.Split("\r\n"))
            .Select(x => x.Select(int.Parse).Sum()).ToArray();

        var aggregatedBlockByIndex = aggregatedBlocks.Select((t, i) => new QueryResult(i + 1, t)).ToList();

        return aggregatedBlockByIndex.OrderByDescending(x => x.Value).Take(elements).ToArray();
        
    }
}