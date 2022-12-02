

namespace MJE.Advent.CalorieCounting.Tests.Unit;

public class CalorieQueryRunnerTests
{
    private static (int, int) RunTest()
    {
        const string calorieList = @"1000
2000
3000

4000

5000
6000

7000
8000
9000

10000";

        return CalorieQueryRunner.Run(calorieList);
    }
    
    [Test]
    public void ReturnCorrectElfIndex()
    {
        
        var (elfIndex, _) = RunTest();
        
        Assert.That(elfIndex, Is.EqualTo(4));

    }

    [Test]
    public void ReturnCorrectCalorieCount()
    {
        
        var (_, totalCalories) = RunTest();
        
        Assert.That(totalCalories, Is.EqualTo(24000));
        
    }
}