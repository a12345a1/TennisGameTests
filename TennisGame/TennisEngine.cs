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
            if (_firstPlayerScoreTimes > 3 || _secondPlayerScoreTimes > 3)
            {
                if (Math.Abs(_firstPlayerScoreTimes - _secondPlayerScoreTimes) == 1)
                {
                    if (_firstPlayerScoreTimes > _secondPlayerScoreTimes)
                    {
                        return $"{_firstPlayerName} Adv";
                    }

                    return $"{_secondPlayerName} Adv";
                }
            }

            return LookupScore();
        }

        if (_firstPlayerScoreTimes >= 3)
        {
            return Deuce();
        }

        return SameScore();
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