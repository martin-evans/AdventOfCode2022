namespace MJE.Advent.NoSpaceLeftOnDevice.Tests.Unit;

public class LiveTests
{
    
    private string GetInput()
    {
        return File.ReadAllText("input.txt");
    }
    

    [Test]
    public void LiveTstOne()
    {
        var sut = new TerminalOutPutParser();
        var res = sut.DeduceFolderSizes(GetInput());

        var result = res.Values.Where(x=> x <= 100000).Sum();

        Console.WriteLine($"Result is {result}");

    }
    
}