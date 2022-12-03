namespace MJE.Advent.RuckSackReOrg.Tests.Unit;

public class RucksackTests
{
    [TestCase("vJrwpWtwJgWrhcsFMMfFFhFp", "p")]
    [TestCase("jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL", "L")]
    [TestCase("PmmdzqPrVvPwwTWBwg", "P")]
    [TestCase("wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn", "v")]
    [TestCase("ttgJtRGJQctTZtZT", "t")]
    [TestCase("CrZsJsPPZsGzwwsLwLmpwMDw", "s")]
    [TestCase("LhNgNvNNhTQMhQMWhvvhfWhllbGGPbPtlPmFlDbjHHdlmg", "g")]
    public void DuplicateItemSetAfterContentsLoaded(string contents, string expectedDuplicate)
    {
        var ruckSack = new RuckSack();

        var duplicateItem = RuckSack.GetDuplicate(contents);

        Assert.That(duplicateItem, Is.EqualTo(expectedDuplicate));
    }
}