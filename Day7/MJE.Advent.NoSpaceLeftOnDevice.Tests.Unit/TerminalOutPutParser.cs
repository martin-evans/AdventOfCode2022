namespace MJE.Advent.NoSpaceLeftOnDevice.Tests.Unit;

public class TerminalOutPutParser
{
    private Folder? _currentFolder;

    public Dictionary<string, long> DeduceFolderSizes(string terminalOutput)
    {
        CreateFolderStructure(terminalOutput);

        var ret = new Dictionary<string, long>();
        
        SetTargetFolderToRoot();
        
        _currentFolder!.CalculateSize();
        
        Flatten(_currentFolder, ret);

        return ret;
    }
    
    private static void Flatten (Folder root , Dictionary<string, long> carry)
    {
        carry.Add($"{root?.ParentFolder}{root.Name}" , root.Size);
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
            _currentFolder!.ProcessLsCommand(opStream.Dequeue());

            if (!opStream.Any()) break;
        } while (!opStream.Peek().StartsWith("$"));
    }

    private void SetTargetFolder(string name)
    {
        if (name == "..")
        {
            _currentFolder = _currentFolder?.ParentFolder;
        }
        else
        {
            _currentFolder = _currentFolder == null
                ? new Folder(name)
                : _currentFolder?
                    .SubFolders
                    .SingleOrDefault(x => x.Name == name);
        }
    }

    private void SetTargetFolderToRoot()
    {
        do
        {
            _currentFolder = _currentFolder?.ParentFolder;
        } while (_currentFolder?.ParentFolder != null);
    }
}