namespace MJE.Advent.RockPaperScissors.Tests.Unit;

public class GameModellingTestsStepOne
{
     [Test]
     public void OpponentShapeSelectedTests()
     {
         var a = (int)ShapeSelected.Rock;
         Assert.That(a, Is.EqualTo(1));
         
         var b = (int)ShapeSelected.Paper;
         Assert.That(b, Is.EqualTo(2));
    
         var c = (int)ShapeSelected.Scissors;
         Assert.That(c, Is.EqualTo(3));
    
     }

    [Test]
    public void OutcomeScoreTests()
    {
        var a = (int)Outcome.Win;
        Assert.That(a, Is.EqualTo(6));
        
        var b = (int)Outcome.Draw;
        Assert.That(b, Is.EqualTo(3));

        var c = (int)Outcome.Loss;
        Assert.That(c, Is.EqualTo(0));
        
    }
    
    [Test]
    public void TestGameRules()
    {
        var guide = new[] {"A Y","B X","C Z"};

        var playerScore = Game.CalculatePlayerScoreVersionOne(guide);
        
        Assert.That(playerScore, Is.EqualTo(15));
        
    }
    
    
    [Test]
    public void TestGameRules_1()
    {
        var guide = new[] {"B Z","B X","C Y", "B Y", "C X"};
        
        var playerScore = Game.CalculatePlayerScoreVersionOne(guide);
        
        Assert.That(playerScore, Is.EqualTo(24));
        
    }
    
    [Test]
    public void TestGameRules_3()
    {
        var guide = new[] {"B X"};
        
        var playerScore = Game.CalculatePlayerScoreVersionOne(guide);
        
        Assert.That(playerScore, Is.EqualTo(1));
        
    }
    
    
    [Test]
    public void TestGameRules_2()
    {
        var guide = new[] {"A X","B X","A Y"};
        
        var playerScore = Game.CalculatePlayerScoreVersionOne(guide);
        
        Assert.That(playerScore, Is.EqualTo(13));
        
    }
    
    
    
    [Test]
    public void TestLiveInput()
    {
        var guide = File.ReadAllLines("input.txt");

        var playerScore = Game.CalculatePlayerScoreVersionOne(guide);
        
        TestContext.Out.WriteLine($"Player score is {playerScore}");
    }

}