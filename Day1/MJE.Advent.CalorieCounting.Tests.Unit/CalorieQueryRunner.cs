namespace MJE.Advent.CalorieCounting.Tests.Unit;

public static class CalorieQueryRunner
{
    public static (int elfIndex, int totalCalories) Run(string calorieList)
    {

        var blocks = calorieList.Split("\r\n\r\n", StringSplitOptions.RemoveEmptyEntries);
        
        var groupedBlocks = blocks.Select(block => block.Split("\r\n").ToArray()).ToList();

        var summedBlocks = groupedBlocks.Select(x => x.Select(int.Parse).Sum()).ToArray();
        
        var dict = new Dictionary<int, int>();

        for (var i = 0; i < summedBlocks.Length; i++)
        {
            dict.Add(i+1, summedBlocks[i]);
        }

        var ret = dict.MaxBy(x => x.Value);
        
        return (ret.Key, ret.Value);
    }
}