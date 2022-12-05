namespace MJE.Advent.SupplyStacks.Tests.Unit;

public struct Move
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