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
        var result = PacketMarkerDetector.Detect(DetectionMode.StartOfPacket, _transmissionText);

        Console.WriteLine($"marker position at {result}");

    }
    
    
    [Test]
    public void LiveTest_Two()
    {
        var result = PacketMarkerDetector.Detect(DetectionMode.StartOfMessage, _transmissionText);

        Console.WriteLine($"Start of message position at {result}");

    }
    
}