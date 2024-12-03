namespace TennisGame;

public class TennisEngine
{
    private readonly Dictionary<int, string> _lookupScore = new Dictionary<int, string>()
    {
        { 0, "Love" },
        { 1, "Fifteen" },
        { 2, "Thirty" },
        { 3, "Forty" },
    };

    private int _firstPlayerScoreTimes;
    private int _secondPlayerScoreTimes;

    public string Score()
    {
        if (_secondPlayerScoreTimes != _firstPlayerScoreTimes)
        {
            return $"{_lookupScore[_firstPlayerScoreTimes]} {_lookupScore[_secondPlayerScoreTimes]}";
        }
        
        if (_firstPlayerScoreTimes>=3)
        {
            return "Deuce";
        }

        return $"{_lookupScore[_firstPlayerScoreTimes]} All";
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