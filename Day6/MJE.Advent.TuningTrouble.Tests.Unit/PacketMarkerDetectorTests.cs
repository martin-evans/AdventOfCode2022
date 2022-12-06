namespace MJE.Advent.TuningTrouble.Tests.Unit;

public class PacketMarkerDetectorTests
{
    [TestCase(DetectionMode.StartOfPacket, "mjqjpqmgbljsphdztnvjfqwrcgsmlb", 7)]
    [TestCase(DetectionMode.StartOfPacket, "bvwbjplbgvbhsrlpgdmjqwftvncz", 5)]
    [TestCase(DetectionMode.StartOfPacket,"nppdvjthqldpwncqszvftbrmjlhg", 6)]
    [TestCase(DetectionMode.StartOfPacket,"nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", 10)]
    [TestCase(DetectionMode.StartOfPacket,"zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw", 11)]
    [TestCase(DetectionMode.StartOfMessage,"mjqjpqmgbljsphdztnvjfqwrcgsmlb", 19)]
    [TestCase(DetectionMode.StartOfMessage,"bvwbjplbgvbhsrlpgdmjqwftvncz", 23)]
    [TestCase(DetectionMode.StartOfMessage,"nppdvjthqldpwncqszvftbrmjlhg", 23)]
    [TestCase(DetectionMode.StartOfMessage,"nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", 29)]
    [TestCase(DetectionMode.StartOfMessage,"zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw", 26)]
    public void DetectMarkerTests(DetectionMode detectionMode, string buffer, int expectedPosition)
    {
        var position = PacketMarkerDetector.Detect(detectionMode,buffer);
        Assert.That(position, Is.EqualTo(expectedPosition));
    }
}