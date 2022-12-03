namespace MJE.Advent.RuckSackReOrg.Tests.Unit;

public class LiveTest
{

    [Test]
    public void Run()
    {
        var contentsArray = File.ReadAllLines("input.txt");
        
        var result = contentsArray
            .Select(s=> ItemPriorityCalculator.Prioritise(RuckSack.GetDuplicate(s)))
            .Sum();
        
        Console.WriteLine($"Sum of priorities is {result}");

    }

    [Test]
    public void DummyRun()
    {
        var contentsArray = @"vJrwpWtwJgWrhcsFMMfFFhFp
jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL
PmmdzqPrVvPwwTWBwg
wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn
ttgJtRGJQctTZtZT
CrZsJsPPZsGzwwsLwLmpwMDw".Split("\r\n");
        
        var result = contentsArray
            .Select(x=> ItemPriorityCalculator.Prioritise(RuckSack.GetDuplicate(x)))
            .Sum();

        Console.WriteLine($"Sum of priorities is {result}");

    }
}