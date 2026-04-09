using System.Reflection.PortableExecutable;

public class Party : IEnumerable<Character>
{
    private List<Character> list = new List<Character>();
    public void AddCharacter(Character character)
    {
        list.Add(character);
    }
    public IEnumerator<Character> GetEnumerator()
    {
        foreach (var character in list)
        {
            yield return character;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public IEnumerable<Character> GetActiveChar()
    {
        foreach (var character in list)
        {
            if (character.State == "Alive")
            {
                yield return character;
            }
        }
    }

}

public class EventLog : IEnumerable<Event>
{
    private List<Event> events = new List<Event>();
    public void Add(Event eventGame)
    {
        events.Add(eventGame);
    }
    public IEnumerator<Event> GetEnumerator()
    {
        foreach (var eventGame in events)
        {
            yield return eventGame;
        }
    }
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    public IEnumerable<Event> GetEvents(string type)
    {
        foreach (var eventGame in events)
        {
            if (eventGame.Type == type)
            {
                yield return eventGame;
            }
        }
    }
}