namespace MJE.Advent.RuckSackReOrg.Tests.Unit;

public class RuckSack
{
    public static string GetDuplicate(string contents)
    {

        // split the items up into two arrays then compare
        var i = contents.Length/2;

        var compartmentOne = contents[..i];
        var compartmentTwo = contents[i..];

        var dup = compartmentOne.Intersect(compartmentTwo).ToArray();

        return dup.Any() ? dup.First().ToString() : string.Empty;
    }
}