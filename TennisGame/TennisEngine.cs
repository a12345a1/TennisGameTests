namespace TennisGame;

public class TennisEngine
{
    private readonly Dictionary<int, string> _lookupScore = new Dictionary<int, string>()
    {
        { 1, "Fifteen" },
        { 2, "Thirty" },
        { 3, "Forty" },
    };

    private int _firstPlayerScoreTimes;
    private int _secondPlayerScoreTimes;

    public string Score()
    {
        if (_secondPlayerScoreTimes == 1)
        {
            return "Love Fifteen";
        }
        
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

    public void SecondPlayerScore()
    {
        _secondPlayerScoreTimes++;
    }
}