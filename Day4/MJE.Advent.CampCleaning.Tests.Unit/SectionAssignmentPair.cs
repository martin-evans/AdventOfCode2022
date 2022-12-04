namespace MJE.Advent.CampCleaning.Tests.Unit;

public class SectionAssignmentPair
{
    private bool _fullOverlapDetected;

    public bool FullOverlapDetected
    {
        get => _fullOverlapDetected;
        private init {  _fullOverlapDetected = value;
            PartialOverlapDetected = true;
        }
    }

    public bool PartialOverlapDetected { get; private init; }

    public SectionAssignmentPair(string sectionAssignments)
    {

        var (elfOneAssignedSection, elfTwoAssignedSection) = ParseAssignedSections(sectionAssignments);
        
        
        FullOverlapDetected = FullOverLapExists(elfOneAssignedSection, elfTwoAssignedSection);

        if (!FullOverlapDetected)
        {
            FullOverlapDetected = FullOverLapExists(elfTwoAssignedSection, elfOneAssignedSection);    
        }

        if (!FullOverlapDetected)
        {
            PartialOverlapDetected = PartialOverlapExists(elfOneAssignedSection, elfTwoAssignedSection);
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

    
    private static bool PartialOverlapExists(IEnumerable<int> arrayOne, IReadOnlyCollection<int> arrayTwo)
    {
        return arrayOne.Intersect(arrayTwo).ToArray().Any();
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