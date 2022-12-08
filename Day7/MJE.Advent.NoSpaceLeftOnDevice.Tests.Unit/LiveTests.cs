namespace MJE.Advent.NoSpaceLeftOnDevice.Tests.Unit;

public class LiveTests
{
    
    private string GetInput()
    {
        return File.ReadAllText("input.txt");
    }
    
    [Test]
    public void LiveTestOne()
    {
        var res = new TerminalOutPutParser().DeduceFolderSizes(GetInput());

        var result = res.Values.Where(x=> x <= 100000).Sum();

        Console.WriteLine($"Result is {result}");

    }
    
    [Test]
    public void LiveTestTwo()
    {
        var minDirectorySize = 838_116_5;
        
        var res = new TerminalOutPutParser().DeduceFolderSizes(GetInput());

        foreach (var keyValuePair in res.Where(x=>x.Value >= minDirectorySize).OrderByDescending(x=>x.Value))
        {
            TestContext.Out.WriteLine(keyValuePair);
        }
        
    }
    
}