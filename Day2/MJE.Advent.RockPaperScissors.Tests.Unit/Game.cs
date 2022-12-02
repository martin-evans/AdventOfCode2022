namespace MJE.Advent.RockPaperScissors.Tests.Unit;

public static class Game
{
    public static int CalculatePlayerScoreVersionOne(IEnumerable<string> strategyGuide)
    {
        return strategyGuide.Select(StrategyOne.CalculatePlayerOneScore).Sum();
    }
    public static int CalculatePlayerScoreVersionTwo(IEnumerable<string> strategyGuide)
    {
        return strategyGuide.Select(StrategyTwo.CalculatePlayerOneScore).Sum();
    }
    
}