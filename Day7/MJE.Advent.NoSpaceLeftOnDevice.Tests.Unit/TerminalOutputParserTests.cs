using System.Transactions;

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
    public void Test1()
    {
        var sut = new TerminalOutPutParser();
        Dictionary<string, int> res = sut.DeduceFolderSizes(TerminalOutput());
        Assert.That(res["/"], Is.EqualTo(48381165));
    }
}