namespace MJE.Advent.RuckSackReOrg.Tests.Unit;

public static class GroupRuckSacks
{
    public static string GetDuplicate(string[] groupRuckSacks)
    {
        var tmp = groupRuckSacks[0].Intersect(groupRuckSacks[1]).ToArray();
        return tmp.Intersect(groupRuckSacks[2]).FirstOrDefault().ToString();
    }
}