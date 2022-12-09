using System.ComponentModel;
using System.Diagnostics;

namespace MJE.Advent.RopeBridge.Tests.Unit;

public static class MotionAnalyser
{
    public static int CalculateVisitedPositions(string input)
    {
        var moves = input
            .Split("\r\n")
            .Select(m => new Move(m))
            .ToArray();

        (int width, int height) = GetWidthAndHeight(moves);

        var Board = Generate(width, height);
        
        // position on board
        
        // figure out max height and width by
        
        return 0;
        // count the positions landed on by the bottom knot of the rope
    }

    private static string[][] Generate(int width, int height)
    {
        var lst = new List<string[]>();
        
        for (var i = 0; i < height; i++)
        {
            var ret = new List<string>();
            
            for (var j = 0; j < width; j++)
            {
                ret.Add(Guid.NewGuid().ToString());
            }
            
            lst.Add(ret.ToArray());
        }
        return lst.ToArray();
        
    }

    private static (int width, int height) GetWidthAndHeight(Move[] moves)
    {
        var width = 0;
        var height = 0;

        int SumOfMovesInDirection(IEnumerable<Move> m, Direction direction) => m.Where(x => x.Direction == direction).Sum(x => x.Amount);

        var movesUp = SumOfMovesInDirection(moves, Direction.Up);
        var movesLeft = SumOfMovesInDirection(moves, Direction.Left);
        
        return (movesLeft+1, movesUp+1);
        
    }

    private struct Move
    {
        public Direction Direction { get; }
        public int Amount { get; }

        public Move(string specification) : this()
        {
            var c = specification.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            Amount = int.Parse(c[1]);
            Direction = Parse(c[0]);
        }

        private Direction Parse(string letter)
        {
            return letter switch
            {
                "U" => Direction.Up,
                "D" => Direction.Down,
                "R" => Direction.Right,
                "L" => Direction.Left,
                _ => throw new InvalidEnumArgumentException()
            };
        }
    }


    private enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }
}