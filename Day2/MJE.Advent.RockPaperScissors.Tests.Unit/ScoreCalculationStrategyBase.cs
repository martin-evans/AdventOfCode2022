namespace MJE.Advent.RockPaperScissors.Tests.Unit;

public abstract class ScoreCalculationStrategyBase
{
    
    protected static int CalculatePlayerScore(ShapeSelected playerShape, ShapeSelected opponentShape)
    {
        var playerScore = (int)playerShape;

        playerScore = playerShape switch
        {
            ShapeSelected.Rock => opponentShape switch
            {
                ShapeSelected.Rock => playerScore + (int)Outcome.Draw,
                ShapeSelected.Scissors => playerScore + (int)Outcome.Win,
                _ => playerScore,
            },
            ShapeSelected.Paper => opponentShape switch
            {
                ShapeSelected.Paper => playerScore + (int)Outcome.Draw,
                ShapeSelected.Rock => playerScore + (int)Outcome.Win,
                _ => playerScore,
            },
            ShapeSelected.Scissors => opponentShape switch
            {
                ShapeSelected.Scissors => playerScore + (int)Outcome.Draw,
                ShapeSelected.Paper => playerScore + (int)Outcome.Win,
                _ => playerScore,
            },
            _ => playerScore
        };

        return playerScore;
    }
    
}