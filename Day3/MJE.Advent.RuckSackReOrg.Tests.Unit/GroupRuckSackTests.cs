namespace MJE.Advent.RuckSackReOrg.Tests.Unit;

public class GroupRuckSackTests
{
    [TestCase("vJrwpWtwJgWrhcsFMMfFFhFp\r\njqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL\r\nPmmdzqPrVvPwwTWBwg", "r")]
    [TestCase("wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn\r\nnttgJtRGJQctTZtZT\r\nCrZsJsPPZsGzwwsLwLmpwMDw", "Z")]
    [TestCase("jLnFTjhwFTLFDGDDvLgvDssBJBbVRNZJPPJBGzBNRVJNRB\r\nQWmffSmMZCfWrmHlCflQWfSNBpVBNbPSbbJNppcVVzzpcp\r\nlflrqrWMmfdMlrtWWmZgDjsqwFwhFDsngnvhqs", "Z")]
    public void GetCommonItemFromGroup(string groupRuckSackContent, string expectedItem)
    {
        var groupRuckSacks = groupRuckSackContent.Split("\r\n");

        Assert.That(GroupRuckSacks.GetDuplicate(groupRuckSacks), Is.EqualTo(expectedItem));

    }
}