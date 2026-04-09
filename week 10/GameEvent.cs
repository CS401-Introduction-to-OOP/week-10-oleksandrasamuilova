public class GameEvent
{
    public int Turn { get; set; }
    public string Description { get; set; }
    public string Type { get; set; }
    public int StatChange { get; set; }

    public GameEvent(int turn, string description, string type, int statChange)
    {
        Turn = turn;
        Description = description;
        Type = type;
        StatChange = statChange;
    }
}