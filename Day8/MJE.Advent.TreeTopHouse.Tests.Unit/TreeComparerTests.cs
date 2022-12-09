namespace MJE.Advent.TreeTopHouse.Tests.Unit;

public class TreeComparerTests
{
    [Test]
    public void Test_CalculateVisibleTrees()
    {
        var treeMap = "30373\r\n25512\r\n65332\r\n33549\r\n35390";
    
        var (visibleTrees, _) = TreeComparer.CalculateVisibleTrees(treeMap);
        
        Assert.That(visibleTrees, Is.EqualTo(21));
    
    }
    
    [Test]
    public void Test_CalculateScenicScore()
    {
        var treeMap = "30373\r\n25512\r\n65332\r\n33549\r\n35390";
    
        var (_, scenicScore) = TreeComparer.CalculateVisibleTrees(treeMap);
        
        Assert.That(scenicScore, Is.EqualTo(8));
    
    }
    
    [Test]
    public void Test_CalculateVisibleTrees_2()
    {
        var treeMap = "33373\r\n21512\r\n65332\r\n33549\r\n35390";
    
        var (visibleTrees, _) = TreeComparer.CalculateVisibleTrees(treeMap);
        
        Assert.That(visibleTrees, Is.EqualTo(20));
    
    }
    
    [Test]
    public void GetTreesTest()
    {
        var treeMap = new[]
        {
            new[] { 3, 0, 3, 7, 3 },
            new[] { 2, 5, 5, 1, 2 },
            new[] { 6, 5, 3, 3, 2 },
            new[] { 3, 3, 5, 4, 9 },
            new[] { 3, 5, 3, 9, 0 },
        };

        var op = TreeComparer.GetSurroundingTrees(3, 2, treeMap);

        Assert.Multiple(() =>
        {
            Assert.That(op["Above"], Is.EqualTo(new[] { 1, 7 }));

            Assert.That(op["Below"], Is.EqualTo(new[] { 4, 9 }));

            Assert.That(op["Right"], Is.EqualTo(new[] { 2 }));

            Assert.That(op["Left"], Is.EqualTo(new[] { 3, 5, 6 }));
        });
    }
    
    [Test]
    public void GetTreesTest2()
    {
        var treeMap = new[]
        {
            new[] { 3, 0, 3, 7, 3 },
            new[] { 2, 5, 5, 1, 2 },
            new[] { 6, 5, 3, 3, 2 },
            new[] { 3, 3, 5, 4, 9 },
            new[] { 3, 5, 3, 9, 0 },
        };

        var op = TreeComparer.GetSurroundingTrees(3, 0, treeMap);

        Assert.Multiple(() =>
        {
            Assert.That(op["Above"], Is.Empty);

            Assert.That(op["Below"], Is.EqualTo(new[] { 1,3,4,9 }));

            Assert.That(op["Right"], Is.EqualTo(new[] { 3 }));

            Assert.That(op["Left"], Is.EqualTo(new[] { 3,0,3 }));
        });
    }
    
}
