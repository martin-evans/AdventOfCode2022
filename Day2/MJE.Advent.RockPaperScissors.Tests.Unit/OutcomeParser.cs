using System.ComponentModel;

namespace MJE.Advent.RockPaperScissors.Tests.Unit;

public static class OutcomeParser
{
    internal static Outcome Parse(char c)
    {
        return c switch
        {
            'X' => Outcome.Loss,
            'Y' => Outcome.Draw,
            'Z' => Outcome.Win,
            _ => throw new InvalidEnumArgumentException("Cannot parse a ShapeFrom input")
        };
    }
}