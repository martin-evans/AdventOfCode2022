namespace MJE.Advent.TreeTopHouse.Tests.Unit;

public static class TreeComparer
{
    public static (int,int) CalculateVisibleTrees(string treeMap)
    {
        var parsedTreeMap = GenerateFromInput(treeMap);

        var height = parsedTreeMap.Length;
        var width = parsedTreeMap[0].Length;

        var visibleTrees = 0;
        var highestScenicScore = 0;

        for (var y = 0; y < height; y++)
        {
            for (var x = 0; x < width; x++)
            {
                var treeHeight = parsedTreeMap[y][x];
                
                var surroundingTrees = GetSurroundingTrees(x, y, parsedTreeMap);
                visibleTrees += CanBeSeen(surroundingTrees, treeHeight);
                
                var scenicScore = CalculateScenicScore(surroundingTrees, treeHeight);
                highestScenicScore = scenicScore > highestScenicScore ? scenicScore : highestScenicScore;

            }
        }

        return (visibleTrees, highestScenicScore);
    }

    private static int CanBeSeen(IReadOnlyDictionary<string, int[]> surroundingTrees, int treeHeight)
    {
        
        bool AreSmaller(int otherTree)
        {
            return otherTree < treeHeight;
        }
                
        var canSeeFromAbove = surroundingTrees["Above"].All(AreSmaller);
        var canSeeFromRight = surroundingTrees["Right"].All(AreSmaller);
        var canSeeFromLeft = surroundingTrees["Left"].All(AreSmaller);
        var canSeeFromBelow = surroundingTrees["Below"].All(AreSmaller);

        if (canSeeFromLeft
            || canSeeFromRight
            || canSeeFromBelow
            || canSeeFromAbove)
        {
            return 1;
        }

        return 0;
    }

    private static int CalculateScenicScore(Dictionary<string,int[]> surroundingTrees, int treeHeight)
    {

        var scenicScores = new List<int>();
        
        surroundingTrees.Select(x=>x.Value)
            .ToList()
            .ForEach(treeHeights=> scenicScores.Add(CalculateIndividualScenicScore(treeHeights, treeHeight)) );

        var score = scenicScores[0] * scenicScores[1] * scenicScores[2] * scenicScores[3];
        
        return score;

    }
    
    private static int CalculateIndividualScenicScore(IEnumerable<int> heightsOfOtherTrees, int treeHeight)
    {
        var scenicScore = 0;
        
        foreach (var otherTreeHeight in heightsOfOtherTrees)
        {
            scenicScore++;
            
            if (otherTreeHeight >= treeHeight)
            {
                break;
            }
        }

        return scenicScore;

    }
    
    public static Dictionary<string, int[]> GetSurroundingTrees(int x, int y, int[][] treeMap)
    {
        var above = new List<int>();

        for (var i = y - 1; i >= 0; i--)
            above.Add(treeMap[i][x]);

        var below = new List<int>();

        for (var i = y + 1; i < treeMap.Length; i++)
            below.Add(treeMap[i][x]);

        var right = treeMap[y][(x + 1)..];

        var left = treeMap[y][..x].Reverse();

        return new Dictionary<string, int[]>
        {
            ["Above"] = above.ToArray(),
            ["Below"] = below.ToArray(),
            ["Right"] = right.ToArray(),
            ["Left"] = left.ToArray()
        };
    }

    private static int[][] GenerateFromInput(string treeMap)
    {
        return treeMap.Split("\r\n")
            .Select(x => x.ToCharArray()
                .Select(d => int.Parse(d.ToString())).ToArray()
            ).ToArray();
    }
}