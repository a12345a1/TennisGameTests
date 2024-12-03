using TennisGame;

namespace TennisGameTests;

public class TennisEngineTests
{
    private TennisEngine _tennisEngine;

    [SetUp]
    public void Setup()
    {
        _tennisEngine = new TennisEngine();
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
        GivenFirstPlayerScore(3);
        GivenSecondPlayerScore(3);
        ScoreShouldBe("Deuce");
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