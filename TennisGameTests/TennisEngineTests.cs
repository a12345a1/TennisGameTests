namespace TennisGameTests;

public class TennisEngineTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void LoveAll()
    {
        var tennisEngine = new TennisEngine();
        Assert.That(tennisEngine.Score(), Is.EqualTo("Love All"));
    }
}

public class TennisEngine
{
    public string Score()
    {
        throw new NotImplementedException();
    }
}