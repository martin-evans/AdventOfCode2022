namespace MJE.Advent.CampCleaning.Tests.Unit;

public class SectionOneLiveRun
{
    [Test]
    public void SectionOne_Run()
    {
        var assignments = File.ReadAllLines("input.txt");
        
        var overlappedPairs = assignments
            .Select(x => new SectionAssignmentPair(x))
            .Where(pair => pair.FullOverlapDetected)
            .ToArray()
            .Length;
        
        TestContext.Out.WriteLine($"{overlappedPairs} full overlap assignments detected");
    }
    
    [Test]
    public void SectionTwo_Run()
    {
        var assignments = File.ReadAllLines("input.txt");
        
        var overlappedPairs = assignments
            .Select(x => new SectionAssignmentPair(x))
            .Where(pair => pair.PartialOverlapDetected)
            .ToArray()
            .Length;
        
        TestContext.Out.WriteLine($"{overlappedPairs} partial overlap assignments detected");


    }
}