namespace MJE.Advent.TuningTrouble.Tests.Unit;

public class LiveTests
{

    private string _transmissionText;
    
    [OneTimeSetUp]
    public void Setup()
    {
        _transmissionText = File.ReadAllText("input.txt");
    }

    [Test]
    public void LiveTest_One()
    {
        var result = PacketMarkerDetector.Detect(_transmissionText);

        Console.WriteLine($"marker position at {result}");

    }
    
}