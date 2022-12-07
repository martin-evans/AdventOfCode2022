namespace MJE.Advent.NoSpaceLeftOnDevice.Tests.Unit;

public class TerminalOutPutParser
{
    
    
    public Dictionary<string, int> DeduceFolderSizes(string terminalOutput)
    {
        var ret = new Dictionary<string, int>();




        //directory - fullname, files, folders

        var commandsOfInterest = new string[] { "\r\n", };

        var commands = terminalOutput.Split(commandsOfInterest, StringSplitOptions.RemoveEmptyEntries).ToList();

        Folder.ProcessLsCommand(commandsOfInterest);
        
        
        commands.ForEach(TestContext.Out.WriteLine);



        // var locations = commands.Where(x => x.StartsWith("$ cd")).Select(x => x.Replace("$cd ", "")).ToList();
        //
        // locations.ForEach(TestContext.Out.WriteLine);
        
        return ret;
    }
}