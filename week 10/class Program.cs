class Program
{
    static void Main()
    {
        Party party = new Party();
        party.Add(new Character("Rodger", "Hero", 1, 100, 23, "Alive"));
        party.Add(new Character("Titan", "Enemy", 3, 60, 2, "Alive"));
        party.Add(new Character("Chikatilo", "Enemy", 5, 15, 3, "Dead"));

        EventLog log = new EventLog();
        log.Add(new GameEvent(1, "Rodger vs Titan", "Fight", -5));
        log.Add(new GameEvent(2, "Rodger vs Chikatilo", "Fight", -15));

        Console.WriteLine("All characters");
        foreach (var character in party)
        {
            Console.WriteLine($"{character.Name} {character.Role}, Health: {character.Health}, State: {character.State}");
        }

        Console.WriteLine("\n Only active");
        foreach (var character in party.GetActiveChar())
        {
            Console.WriteLine($"{chatacter.Name} is active");
        }

        Console.WriteLine("\n Fights");
        foreach (var eventGame in log.GetEvents("Fight"))
        {
            Console.WriteLine($"Turn {eventGame.Turn}: {eventGame.Description}");
        }

        var strongHeroes = party
            .Where(character => character.Health > 50)
            .OrderByDescending(character => character.Health);

        Console.WriteLine("Health > 50:");
        foreach (var character in strongHeroes) Console.WriteLine($"{character.Name}, {character.Health}");

        var grouped = party.GroupBy(character => character.Role);
        
        foreach (var group in grouped)
        {
            Console.WriteLine($"Role {group.Key} Amount: {group.Count()})");
            foreach (var character in group)
            {
                Console.WriteLine($"{c.Name}");
            }
        }
    }
}
    