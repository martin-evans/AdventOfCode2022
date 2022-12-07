namespace MJE.Advent.NoSpaceLeftOnDevice.Tests.Unit;

public class FolderTests
{
    [Test]
    public void ProcessLsCommand_ReturnsFolderInstance()
    {
        var commandStream = @"dir a
14848514 b.txt
8504156 c.dat";

        var folderName = "/";

        var folder = new Folder(folderName, null);

        folder.ProcessLsCommand(commandStream);

        Assert.Multiple(() =>
        {
            Assert.That(folder.Name, Is.EqualTo("/"));
            Assert.That(folder.SubFolders.Count(f => f.Name == "a"), Is.EqualTo(1));
            Assert.That(folder.Files.Count(f => f.Key == "b.txt"), Is.EqualTo(1));
            Assert.That(folder.Files.Count(f => f.Key == "c.dat"), Is.EqualTo(1));
            Assert.That(folder.Files["c.dat"], Is.EqualTo(8504156));
            Assert.That(folder.Files["b.txt"], Is.EqualTo(14848514));
        });
    }
}