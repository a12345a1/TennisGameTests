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
    private string _firstPlayerName;
    private string _secondPlayerName;

    public TennisEngine(string firstPlayerName, string secondPlayerName)
    {
        _firstPlayerName = firstPlayerName;
        _secondPlayerName = secondPlayerName;
    }

    public string Score()
    {
        if (IsScoreDifferent())
        {
            if (IsReadyForGamePoint())
            {
                if (IsAdv())
                {
                    return $"{AdvPlayer()} Adv";
                }
            }

            return LookupScore();
        }

        return IsDeuce() ? Deuce() : SameScore();
    }

    private bool IsDeuce()
    {
        return _firstPlayerScoreTimes >= 3;
    }

    private bool IsReadyForGamePoint()
    {
        return _firstPlayerScoreTimes > 3 || _secondPlayerScoreTimes > 3;
    }

    private bool IsAdv()
    {
        return Math.Abs(_firstPlayerScoreTimes - _secondPlayerScoreTimes) == 1;
    }

    private string AdvPlayer()
    {
        return _firstPlayerScoreTimes > _secondPlayerScoreTimes ? _firstPlayerName : _secondPlayerName;
    }

    private string SameScore()
    {
        return $"{_lookupScore[_firstPlayerScoreTimes]} All";
    }

    private static string Deuce()
    {
        return "Deuce";
    }

    private string LookupScore()
    {
        return $"{_lookupScore[_firstPlayerScoreTimes]} {_lookupScore[_secondPlayerScoreTimes]}";
    }

    private bool IsScoreDifferent()
    {
        return _secondPlayerScoreTimes != _firstPlayerScoreTimes;
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