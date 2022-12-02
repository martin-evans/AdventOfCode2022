using System.ComponentModel;

namespace MJE.Advent.RockPaperScissors.Tests.Unit;

public static class Game

{
    public static int CalculatePlayerScore(IEnumerable<string> strategyGuide)
    {
        var rounds = strategyGuide.Select(turns=> new Round(turns));
        
        return rounds.Sum(x => x.PlayerScore);

    }

    private class Round
    {
        public int PlayerScore { get;  }
    
        public Round(string turn)
        {

            var opponentShape = ShapeParser.Parse(turn[0]);

            var playerShape = ShapeParser.Parse(turn[2]);

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

            PlayerScore = playerScore;

        }
    
    }

    private static class ShapeParser
    {
        internal static ShapeSelected Parse(char c)
        {
            switch (c)
            {
                case 'A':
                case 'X': return ShapeSelected.Rock;
                
                case 'B':
                case 'Y': return ShapeSelected.Paper;
                
                case 'C':
                case 'Z': return ShapeSelected.Scissors;
                
                default:
                    throw new InvalidEnumArgumentException("Cannot parse a ShapeFrom input");
                
            }
        }
    }
    
}