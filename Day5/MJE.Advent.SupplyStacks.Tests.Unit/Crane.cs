namespace MJE.Advent.SupplyStacks.Tests.Unit;

public abstract class Crane
{
    public void Operate(List<Stack<char>> stackList, string[] rearrangementProcedure)
    {
        var moves = rearrangementProcedure.Select(r => new Move(r));

        SortStrategy(stackList, moves);
    }
    protected abstract void SortStrategy(List<Stack<char>> stackList, IEnumerable<Move> moves);
    
}