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
        _tennisEngine.FirstPlayerScore();
        ScoreShouldBe("Fifteen Love");
    }

    [Test]
    public void ThirtyLove()
    {
        _tennisEngine.FirstPlayerScore();
        _tennisEngine.FirstPlayerScore();
        ScoreShouldBe("Thirty Love");
    }

    private void ScoreShouldBe(string expected)
    {
        Assert.That(_tennisEngine.Score(), Is.EqualTo(expected));
    }
}