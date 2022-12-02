namespace MJE.Advent.RockPaperScissors.Tests.Unit;

public class StrategyOne : ScoreCalculationStrategyBase
{
    public static int CalculatePlayerOneScore(string turn)
    {
        var opponentShape = ShapeParser.Parse(turn[0]);

        var playerShape = ShapeParser.Parse(turn[2]);
        
        return CalculatePlayerScore(playerShape, opponentShape);

    }
}