namespace TennisGame;

public class TennisEngine
{
    private int _firstPlayerScoreTimes;

    private readonly Dictionary<int, string> _lookupScore = new Dictionary<int, string>()
    {
        { 1, "Fifteen" },
        { 2, "Thirty" },
    };

    public string Score()
    {
        if (_firstPlayerScoreTimes > 0)
        {
            return $"{_lookupScore[_firstPlayerScoreTimes]} Love";
        }

        return "Love All";
    }

    public void FirstPlayerScore()
    {
        _firstPlayerScoreTimes++;
    }
}