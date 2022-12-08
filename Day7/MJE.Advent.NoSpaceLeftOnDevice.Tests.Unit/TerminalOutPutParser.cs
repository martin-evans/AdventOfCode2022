namespace MJE.Advent.NoSpaceLeftOnDevice.Tests.Unit;

public class TerminalOutPutParser
{
    public Folder? CurrentFolder { get; private set; }

    public Dictionary<string, long> DeduceFolderSizes(string terminalOutput)
    {
        CreateFolderStructure(terminalOutput);

        var ret = new Dictionary<string, long>();
        
        SetTargetFolderToRoot();
        
        CurrentFolder!.CalculateSize();
        
        Flatten(CurrentFolder, ret);

        return ret;
    }
    
    private static void Flatten (Folder root , Dictionary<string, long> carry)
    {
        var prefix = root.ParentFolder != null ? $"{root.ParentFolder.Name}/" : "";
        
        carry.Add($"{prefix}{root.Name}/{Guid.NewGuid().ToString()}" , root.Size);
        root.SubFolders.ToList().ForEach( x=> Flatten(x, carry));
        
    }
    
    private void CreateFolderStructure(string terminalOutput)
    {
        var commands = terminalOutput.Split("\r\n", StringSplitOptions.RemoveEmptyEntries).ToList();

        var opStream = new Queue<string>(commands);

        do
        {
            var nxtCmd = opStream.Dequeue();

            if (nxtCmd.StartsWith("$ cd"))
                ProcessCdCommand(nxtCmd);

            if (nxtCmd.StartsWith("$ ls"))
                ProcessLsCommand(opStream);
        } while (opStream.Any());
    }

    private void ProcessCdCommand(string nxtCmd)
    {
        var dirName = nxtCmd.Split(" ")[2];
        SetTargetFolder(dirName);
    }

    private void ProcessLsCommand(Queue<string> opStream)
    {
        do
        {
            CurrentFolder!.ProcessLsCommand(opStream.Dequeue());

            if (!opStream.Any()) break;
        } while (!opStream.Peek().StartsWith("$"));
    }

    private void SetTargetFolder(string name)
    {
        if (name == "..")
        {
            CurrentFolder = CurrentFolder?.ParentFolder;
        }
        else
        {
            CurrentFolder = CurrentFolder == null
                ? new Folder(name)
                : CurrentFolder?
                    .SubFolders
                    .SingleOrDefault(x => x.Name == name);
        }
    }

    private void SetTargetFolderToRoot()
    {
        do
        {
            CurrentFolder = CurrentFolder?.ParentFolder;
        } while (CurrentFolder?.ParentFolder != null);
    }
}