namespace MJE.Advent.CampCleaning.Tests.Unit;

public class SectionAssignmentPairTests
{
 
    [TestCase("2-4,6-8", false)]
    [TestCase("2-8,3-7", true)]
    [TestCase("4-6, 2-8", true)]
    public void FullyOverlapped_Tests(string assignments, bool expectation)
    {
        var sectionAssignmentPair = new SectionAssignmentPair(assignments);
        Assert.That(sectionAssignmentPair.FullOverlapDetected, Is.EqualTo(expectation));
    }
    
    
    [TestCase("2-4,6-8", false)]
    [TestCase("2-8,3-7", true)]
    [TestCase("4-6, 2-8", true)]
    [TestCase("1-5, 3-7", true)]
    [TestCase("3-7, 1-4", true)]
    [TestCase("2-3,4-5", false)]
    public void PartialOverlapped_Tests(string assignments, bool expectation)
    {
        var sectionAssignmentPair = new SectionAssignmentPair(assignments);
        Assert.That(sectionAssignmentPair.PartialOverlapDetected, Is.EqualTo(expectation));
    }
}