

using NUnit.Framework.Constraints;

namespace MJE.Advent.CalorieCounting.Tests.Unit;

public class CalorieQueryRunnerTests
{
    private static QueryResult RunTest()
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

        return CalorieQueryRunner.Run(calorieList, 1).First();
    }
    
    [Test]
    public void ReturnCorrectElfIndex()
    {
        
        var  result = RunTest();
        
        Assert.That(result.Id, Is.EqualTo(4));

    }

    [Test]
    public void ReturnCorrectCalorieCount()
    {
        var  result = RunTest();
        
        Assert.That(result.Value, Is.EqualTo(24000));
        
    }
}