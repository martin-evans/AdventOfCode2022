namespace MJE.Advent.CampCleaning.Tests.Unit;

public class SectionAssignmentPair
{
    public bool FullOverlapDetected { get; }
    
    public SectionAssignmentPair(string sectionAssignments)
    {

        var (elfOneAssignedSection, elfTwoAssignedSection) = ParseAssignedSections(sectionAssignments);
        
        FullOverlapDetected = FullOverLapExists(elfOneAssignedSection, elfTwoAssignedSection);

        if (!FullOverlapDetected)
        {
            FullOverlapDetected = FullOverLapExists(elfTwoAssignedSection, elfOneAssignedSection);    
        }
        
    }

    private static (int[], int[]) ParseAssignedSections(string sectionAssignments)
    {
        var assignedSections = sectionAssignments
            .Split(",")
            .Select(GenerateIntArray)
            .ToArray();
        
        return(assignedSections[0], assignedSections[1]);
        
    }

    private static bool FullOverLapExists(IEnumerable<int> arrayOne, IReadOnlyCollection<int> arrayTwo)
    {
        var res = arrayOne.Intersect(arrayTwo).ToArray();

        return res.Length == arrayTwo.Count;
    }

    private static int[] GenerateIntArray(string s)
    {
        var startStop = s.Split("-").Select(int.Parse).ToArray();

        var start = startStop[0];
        var stop = startStop[1] - start +1;
        
        return Enumerable.Range(start, stop).ToArray();
    }

    
}