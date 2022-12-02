namespace MJE.Advent.CalorieCounting.Tests.Unit;

public class QueryResult
{
    public int Id { get; }
    public int Value { get; }

    public QueryResult(int id, int value)
    {
        Id = id;
        Value = value;
    }
}