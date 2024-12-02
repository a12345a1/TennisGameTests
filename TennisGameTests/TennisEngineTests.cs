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