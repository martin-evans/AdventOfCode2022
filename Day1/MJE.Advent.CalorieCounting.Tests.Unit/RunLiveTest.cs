namespace MJE.Advent.CalorieCounting.Tests.Unit;

public class RunLiveTest
{
    [Test]
    public void Run()
    {
        var liveData = File.ReadAllText("LiveData.txt");

        var queryResults = CalorieQueryRunner.Run(liveData, 3);

        Console.WriteLine($"Elf number {queryResults.First().Id} has the most calories with {queryResults.First().Value}");
        
        Console.WriteLine($"Combined calories from top 3 elves {queryResults.Select(x=>x.Value).Sum()} ");
    }
}