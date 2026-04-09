using System.Dynamic;

public abstract class Character
{
    public string Name{get; set;}
    public string Role {get; set;}
    public int Level {get; set;}
    public int Health {get; set;}
    public int GoldAmount {get; set;}
    public string State  {get; set;}

    Character(string name, string role, int level, int health, int goldAmount, string state)
    {
        Name = name;
        Role = role;
        Level = level;
        Health = health;
        GoldAmount = goldAmount;
        State = state;
    }

}