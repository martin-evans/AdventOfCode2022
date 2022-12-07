namespace MJE.Advent.NoSpaceLeftOnDevice.Tests.Unit;

internal class Folder
{
    private readonly List<Folder> _subFolders = new List<Folder>();

    private Folder(string fullName)
    {
        FullName = fullName;
    }

    public string FullName { get; private  set; }

    public Dictionary<string, int> Files { get; set; } = new Dictionary<string, int>();

    public Folder[] SubFolders => _subFolders.ToArray();

    public static Folder ProcessLsCommand(string commandStream, string fullName)
    {
        var ret = new Folder(fullName);

        ret.ParseCommandStream(commandStream);

        return ret;
    }

    private void ParseCommandStream(string commandStream)
    {
        // go from ls, down to next line with a $

        var outputBlocks = commandStream.Split("$s").First().Split("\r\n").Skip(1);

        foreach (var outputBlock in outputBlocks)
        {
            if (outputBlock.StartsWith("dir"))
            {
                var name = outputBlock.Split(" ")[1];
                var fullName = $"{FullName}{name}";
                _subFolders.Add(new Folder(fullName));
            }
            else
            {
                var fileDetails = outputBlock.Split(" ");
                var fileSize = int.Parse(fileDetails[0]);
                var fileName = fileDetails[1];
                Files.Add(fileName, fileSize);
            }
        }
    }
}