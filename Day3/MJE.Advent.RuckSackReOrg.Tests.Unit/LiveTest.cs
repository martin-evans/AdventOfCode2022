namespace MJE.Advent.RuckSackReOrg.Tests.Unit;

public class LiveTest
{

    private string[]? _contentsArray;

    [OneTimeSetUp]
    public void ReadFileData()
    {
        _contentsArray = File.ReadAllLines("input.txt");
    }
    

    [Test]
    public void RunTestOne()
    {

        var result = _contentsArray?
            .Select(s=> ItemPriorityCalculator.Prioritise(RuckSack.GetDuplicate(s)))
            .Sum();
        
        Console.WriteLine($"Sum of priorities is {result}");

    }
    
    
    [Test]
    public void RunTestTwo()
    {
        var sum = 0;
        const int elvesPerGroup = 3;
        
        for (var i = 0; i < _contentsArray?.Length; i += elvesPerGroup)
        {
            var c = _contentsArray[i..(i+elvesPerGroup)].ToArray();
            var duplicate = GroupRuckSacks.GetDuplicate(c);
            sum += ItemPriorityCalculator.Prioritise(duplicate);
        }
        
        Console.WriteLine($"Sum of priorities is {sum}");

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