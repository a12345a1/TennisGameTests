using TennisGame;

namespace TennisGameTests;

public class TennisEngineTests
{
    private TennisEngine _tennisEngine;

    [SetUp]
    public void Setup()
    {
        _tennisEngine = new TennisEngine("Player1", "Player2");
    }

    [Test]
    public void LoveAll()
    {
        ScoreShouldBe("Love All");
    }

    [Test]
    public void FifteenLove()
    {
        GivenFirstPlayerScore(1);
        ScoreShouldBe("Fifteen Love");
    }

    [Test]
    public void ThirtyLove()
    {
        GivenFirstPlayerScore(2);
        ScoreShouldBe("Thirty Love");
    }

    [Test]
    public void FortyLove()
    {
        GivenFirstPlayerScore(3);
        ScoreShouldBe("Forty Love");
    }

    [Test]
    public void Love_Fifteen()
    {
        GivenSecondPlayerScore(1);
        ScoreShouldBe("Love Fifteen");
    }
    
    [Test]
    public void Love_Thirty()
    {
        GivenSecondPlayerScore(2);
        ScoreShouldBe("Love Thirty");
    }

    [Test]
    public void Fifteen_All()
    {
        GivenFirstPlayerScore(1);
        GivenSecondPlayerScore(1);
        ScoreShouldBe("Fifteen All");
    }
    
    [Test]
    public void Thirty_All()
    {
        GivenFirstPlayerScore(2);
        GivenSecondPlayerScore(2);
        ScoreShouldBe("Thirty All");
    }
    
    [Test]
    public void Deuce()
    {
        GivenDeuce();
        ScoreShouldBe("Deuce");
    }

    [Test]
    public void FirstPlayerAdv()
    {
        GivenDeuce();
        GivenFirstPlayerScore(1);
        ScoreShouldBe("Player1 Adv");
    }
    
    [Test]
    public void SecondPlayerAdv()
    {
        GivenDeuce();
        GivenSecondPlayerScore(1);
        ScoreShouldBe("Player2 Adv");
    }
    
    [Test]
    public void FirstPlayerWin()
    {
        GivenDeuce();
        GivenFirstPlayerScore(2);
        ScoreShouldBe("Player1 Win");
    }
    
    [Test]
    public void SecondPlayerWin()
    {
        GivenDeuce();
        GivenSecondPlayerScore(2);
        ScoreShouldBe("Player2 Win");
    }
    
    private void GivenDeuce()
    {
        GivenFirstPlayerScore(3);
        GivenSecondPlayerScore(3);
    }

    private void GivenSecondPlayerScore(int times)
    {
        for (var i = 0; i < times; i++)
        {
            _tennisEngine.SecondPlayerScore();
        }
    }

    private void GivenFirstPlayerScore(int times)
    {
        for (var i = 0; i < times; i++)
        {
            _tennisEngine.FirstPlayerScore();
        }
    }

    private void ScoreShouldBe(string expected)
    {
        Assert.That(_tennisEngine.Score(), Is.EqualTo(expected));
    }
}