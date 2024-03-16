using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       
        Dictionary<string, string> players = new Dictionary<string, string>
        {
            {"P1", "Chris"},
            {"P2", "James"},
            {"P3", "Mark"},
            {"P4", "Ethan"},
            {"P5", "Brad"}
        };

       
        Console.WriteLine("Keys:");
        foreach (var key in players.Keys)
        {
            Console.WriteLine(key);
        }

        
        Console.WriteLine("\nValues:");
        foreach (var value in players.Values)
        {
            Console.WriteLine(value);
        }

       
        Console.WriteLine("\nKeys and Values:");
        foreach (var kvp in players)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }

        
        if (players.ContainsKey("P3"))
        {
            players.Remove("P3");
            Console.WriteLine("\nplayer with key 'P3' removed.");
        }

        
        Console.WriteLine($"\nTotal players in the party: {players.Count}");
    }
}
