namespace MJE.Advent.RockPaperScissors.Tests.Unit;

public class GameModellingTestsStepTwo
{
    
    [Test]
    public void TestGameRules()
    {
        var guide = new[] {"A Y","B X","C Z"};

        var playerScore = Game.CalculatePlayerScoreVersionTwo(guide);
        
        Assert.That(playerScore, Is.EqualTo(12));
        
    }

    [Test]
    public void TestLiveInput()
    {
        var guide = File.ReadAllLines("input.txt");
    
        var playerScore = Game.CalculatePlayerScoreVersionTwo(guide);
        
        TestContext.Out.WriteLine($"Player score is {playerScore}");
        
        // 12767 is the correct answer
    }

}