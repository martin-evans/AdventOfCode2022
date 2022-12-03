namespace MJE.Advent.RuckSackReOrg.Tests.Unit;

public static class ItemPriorityCalculator
{
    private const string Letters = " abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

    public static int Prioritise(string s)
    {
        return Letters.IndexOf(s, StringComparison.Ordinal);
    }
}