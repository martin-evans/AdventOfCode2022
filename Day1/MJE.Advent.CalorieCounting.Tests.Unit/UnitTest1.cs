using NUnit.Framework.Constraints;

namespace MJE.Advent.CalorieCounting.Tests.Unit;

public class Tests
{


    (int, int) RunTest()
    {
        
        var calorieList = @"1000
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
        
        (int elfIndex, _ ) = RunTest();
        
        Assert.AreEqual(4,elfIndex);

    }

    // [Test]
    // public void ReturnCorrectCalorieCount()
    // {
    //     
    //     (_, int totalCalories ) = RunTest();
    //     
    //     Assert.AreEqual(2400,totalCalories);
    //     
    // }
}

public class CalorieQueryRunner
{
    public static (int elfIndex, int totalCalories) Run(string calorieList)
    {
        return (0, 0);
    }
}