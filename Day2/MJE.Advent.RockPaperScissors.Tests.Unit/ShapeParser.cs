using System.ComponentModel;

namespace MJE.Advent.RockPaperScissors.Tests.Unit;

public static class ShapeParser
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