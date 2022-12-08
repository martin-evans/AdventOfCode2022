namespace MJE.Advent.NoSpaceLeftOnDevice.Tests.Unit;

public class TerminalOutputParserTests
{
    private string TerminalOutput()
    {
        return @"$ cd /
$ ls
dir a
14848514 b.txt
8504156 c.dat
dir d
$ cd a
$ ls
dir e
29116 f
2557 g
62596 h.lst
$ cd e
$ ls
584 i
$ cd ..
$ cd ..
$ cd d
$ ls
4060174 j
8033020 d.log
5626152 d.ext
7214296 k";
    }

    [Test]
    public void DeduceFolderSizes_ReturnsExpectedFolderSizeForRoot()
    {
        var sut = new TerminalOutPutParser();
        Dictionary<string, long> res = sut.DeduceFolderSizes(TerminalOutput());
        Assert.That(res["/"], Is.EqualTo(48381165));
    }
    

    [Test]
    public void ProcessLsCommand_FolderStructureReturnedAsExpected()
    {
        var sut = new TerminalOutPutParser();
        _ = sut.DeduceFolderSizes(TerminalOutput());

        var folder = sut.CurrentFolder;

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