namespace MJE.Advent.SupplyStacks.Tests.Unit;

public class CrateMover9001 : Crane
{
    protected override void SortStrategy(List<Stack<char>> stackList, IEnumerable<Move> moves)
    {

        var lst = new List<char>();

        foreach (var move in moves)
        {
            for (var i = 0; i < move.Qty; i++)
            {
                lst.Add(stackList[move.From - 1].Pop());
            }

            lst.Reverse(); 
            lst.ForEach(crate=> stackList[move.To - 1].Push(crate));
            lst.Clear();
        }
        
        
    }
}