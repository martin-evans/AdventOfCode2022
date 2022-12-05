namespace MJE.Advent.SupplyStacks.Tests.Unit;

public class Crane
{
    public static void Operate(List<Stack<char>> stackList, string[] rearrangementProcedure)
    {
        var moves = rearrangementProcedure.Select(r => new Move(r));
        
        foreach (var move in moves)
            for (var i = 0; i < move.Qty; i++)
            {
                var c = stackList[move.From-1].Pop();
                stackList[move.To-1].Push(c);
            }
        
    }

    private struct Move
    {
        public int Qty { get; }
        public int From { get; }
        public int To { get; }

        public Move(string singleProcedure)
        {
            var x = singleProcedure.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Qty = int.Parse(x[1]);
            From = int.Parse(x[3]);
            To = int.Parse(x[5]);
        }
    }
}