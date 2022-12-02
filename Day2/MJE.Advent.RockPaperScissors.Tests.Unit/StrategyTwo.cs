namespace MJE.Advent.RockPaperScissors.Tests.Unit;

public class StrategyTwo : ScoreCalculationStrategyBase
{
    public static int CalculatePlayerOneScore(string turn)
    {
        var opponentShape = ShapeParser.Parse(turn[0]);
        
        var requiredOutcome = OutcomeParser.Parse(turn[2]);
        
        var playerShape = WorkOutShapeRequiredForRequiredOutCome(opponentShape, requiredOutcome);
        
        return CalculatePlayerScore(playerShape, opponentShape);
    }

    private static ShapeSelected WorkOutShapeRequiredForRequiredOutCome(ShapeSelected opponentShape, Outcome requiredOutcome)
    {
        var playerShape = opponentShape switch
        {
            Unit.ShapeSelected.Rock => requiredOutcome switch
            {
                Outcome.Loss => Unit.ShapeSelected.Scissors,
                Outcome.Draw => Unit.ShapeSelected.Rock,
                Outcome.Win => Unit.ShapeSelected.Paper,
                _ => throw new ArgumentOutOfRangeException()
            },
            Unit.ShapeSelected.Paper => requiredOutcome switch
            {
                Outcome.Loss => Unit.ShapeSelected.Rock,
                Outcome.Draw => Unit.ShapeSelected.Paper,
                Outcome.Win => Unit.ShapeSelected.Scissors,
                _ => throw new ArgumentOutOfRangeException()
            },
            Unit.ShapeSelected.Scissors => requiredOutcome switch
            {
                Outcome.Loss => Unit.ShapeSelected.Paper,
                Outcome.Draw => Unit.ShapeSelected.Scissors,
                Outcome.Win => Unit.ShapeSelected.Rock,
                _ => throw new ArgumentOutOfRangeException()
            },
            _ => throw new ArgumentOutOfRangeException()
        };
        return playerShape;
    }
}