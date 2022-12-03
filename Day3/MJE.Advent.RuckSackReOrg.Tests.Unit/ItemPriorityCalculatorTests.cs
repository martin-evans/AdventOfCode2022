namespace MJE.Advent.RuckSackReOrg.Tests.Unit;

public class ItemPriorityCalculatorTests
{
    [TestCase("p",16)]
    [TestCase("L",38)]
    [TestCase("P",42)]
    [TestCase("v",22)]
    [TestCase("t",20)]
    [TestCase("s",19)]
    public void ItemIsPrioritisedBasedOnValue(string letter, int expectedPriority)
    {
        Assert.That(ItemPriorityCalculator.Prioritise(letter), Is.EqualTo(expectedPriority));
    }
}