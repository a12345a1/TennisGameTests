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
        _tennisEngine.SecondPlayerScore();
        ScoreShouldBe("Love Fifteen");
    }
    
    [Test]
    public void Love_Thirty()
    {
        _tennisEngine.SecondPlayerScore();
        _tennisEngine.SecondPlayerScore();
        ScoreShouldBe("Love Thirty");
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