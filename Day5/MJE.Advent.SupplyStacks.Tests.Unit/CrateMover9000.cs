namespace MJE.Advent.SupplyStacks.Tests.Unit;

public class CrateMover9000 : Crane
{
    protected override void SortStrategy(List<Stack<char>> stackList, IEnumerable<Move> moves)
    {
        foreach (var move in moves)
            for (var i = 0; i < move.Qty; i++)
            {
                var c = stackList[move.From - 1].Pop();
                stackList[move.To - 1].Push(c);
            }
    }
    
}