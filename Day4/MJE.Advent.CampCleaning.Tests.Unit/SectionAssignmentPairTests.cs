namespace MJE.Advent.CampCleaning.Tests.Unit;

public class SectionAssignmentPairTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase("2-4,6-8", false)]
    [TestCase("2-8,3-7", true)]
    [TestCase("4-6, 2-8", true)]
    public void FullyOverlapped_Tests(string assignments, bool expectation)
    {
        var sectionAssignmentPair = new SectionAssignmentPair(assignments);
        Assert.That(sectionAssignmentPair.FullOverlapDetected, Is.EqualTo(expectation));
    }
}

public class SectionOneLiveRun
{
    [Test]
    public void Run()
    {
        var assignments = File.ReadAllLines("input.txt");
        
        var overlappedPairs = assignments
            .Select(x => new SectionAssignmentPair(x))
            .Where(pair => pair.FullOverlapDetected)
            .ToArray()
            .Length;
        
        TestContext.Out.WriteLine($"{overlappedPairs} assignments detected");


    }
}