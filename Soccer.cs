using System;
using System.Collections.Generic;

public class SoccerPlayer
{
    public string Name { get; set; }
    public int JerseyNumber { get; set; }

    // 1. What would make sense to have here? 
    
    // 2. How do these Violate SRP?
    public void ScoreGoal()
    {
        Console.WriteLine($"{Name} scored a goal!");
    }

    // 2. 
    public void Defend()
    {
        Console.WriteLine($"{Name} is defending.");
    }

    // 2. 
    public void Celebrate()
    {
        Console.WriteLine($"{Name} is celebrating!");
    }

    // 3. How can you refactor this to not violate OCP?
    public void PlayGame(List<Action> actions)
    {
        foreach (var action in actions)
        {
            action.Invoke();
        }
    }
}

class Program
{
    static void Main()
    {
        SoccerPlayer player1 = new SoccerPlayer { Name = "John", JerseyNumber = 10 };

        List<Action> player1Actions = new List<Action>
        {
            // B. Violates OCP
            () => player1.Defend(),
            () => player1.ScoreGoal(),
            () => player1.Celebrate()
        };

        player1.PlayGame(player1Actions);
    }
}



