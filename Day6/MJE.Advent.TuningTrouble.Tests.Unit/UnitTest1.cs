namespace MJE.Advent.TuningTrouble.Tests.Unit;

public class StartOfPacketMarkerDetectorTest
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase("mjqjpqmgbljsphdztnvjfqwrcgsmlb", 7)]
    [TestCase("bvwbjplbgvbhsrlpgdmjqwftvncz", 5)]
    [TestCase("nppdvjthqldpwncqszvftbrmjlhg", 6)]
    [TestCase("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", 10)]
    [TestCase("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw", 11)]
    public void DetectMarkerTests(string buffer, int expectedPosition)
    {
        var position = PacketMarkerDetector.Detect(buffer);
        Assert.That(position, Is.EqualTo(expectedPosition));
    }
}