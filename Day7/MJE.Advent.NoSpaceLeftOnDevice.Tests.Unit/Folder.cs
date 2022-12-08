namespace MJE.Advent.NoSpaceLeftOnDevice.Tests.Unit;

public class Folder
{
    public Folder? ParentFolder { get; }
    
    public string Name { get; }
    
    private readonly List<Folder> _subFolders = new();

    public Folder(string name, Folder? parent = null)
    {
        ParentFolder = parent;
        Name = name;
    }

    public Dictionary<string, int> Files { get; set; } = new();

    public Folder[] SubFolders => _subFolders.ToArray();

    public void ProcessLsCommand(string commandStream)
    {
        if (commandStream.StartsWith("dir"))
        {
            var name = commandStream.Split(" ")[1];
            _subFolders.Add(new Folder(name, this));
        }
        else
        {
            var fileDetails = commandStream.Split(" ");
            var fileSize = int.Parse(fileDetails[0]);
            var fileName = fileDetails[1];
            Files.Add(fileName, fileSize);
        }
    }
    
    public override string ToString()
    {
        return $"{Name} : {Size} bytes";
    }

    public long Size { get; private set; }

    public void CalculateSize()
    {
        Size = Files.Values.Sum();

        _subFolders.ForEach(x =>
        {
            x.CalculateSize();
            Size += x.Size;
        });
        
    }
}