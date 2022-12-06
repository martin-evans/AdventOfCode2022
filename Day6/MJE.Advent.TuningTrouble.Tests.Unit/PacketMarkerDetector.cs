namespace MJE.Advent.TuningTrouble.Tests.Unit;

public static class PacketMarkerDetector
{
    private const int MarkerCount = 4;
    
    public static int Detect(string buffer)
    {
        var uniqueCharacterList = new List<char>();

        for (var i = 0; i < buffer.Length; i++)
        {
            uniqueCharacterList.Add(buffer[i]);

            if (uniqueCharacterList.Distinct().Count() == MarkerCount)
                return i + 1;

            if (uniqueCharacterList.Count == MarkerCount)
                uniqueCharacterList.RemoveAt(0);
        }

        return -1;
    }
}