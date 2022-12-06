namespace MJE.Advent.TuningTrouble.Tests.Unit;

public static class PacketMarkerDetector
{
    public static int Detect(DetectionMode detectionMode, string buffer)
    {
        var markerCount = (int)detectionMode;

        var uniqueCharacterList = new List<char>();

        for (var i = 0; i < buffer.Length; i++)
        {
            uniqueCharacterList.Add(buffer[i]);

            if (uniqueCharacterList.Distinct().Count() == markerCount)
                return i + 1;

            if (uniqueCharacterList.Count == markerCount)
                uniqueCharacterList.RemoveAt(0);
        }

        return -1;
    }
}