namespace exercise4;

public class Program
{
    static void Main()
    {
        // Create players
        SoccerPlayer player1 = new SoccerPlayer("Player1", 22, Gender.Male, Position.Midfielder);
        SoccerPlayer player2 = new SoccerPlayer("Player2", 25, Gender.Male, Position.Striker);

        // Create team
        SoccerTeam myTeam = new SoccerTeam("SoccerTeam", Gender.Male, SoccerTeam.NO_AGE_LIMIT);

        // Add players to team
        myTeam.AddPlayer(player1);
        myTeam.AddPlayer(player2);

        // Output
        Console.WriteLine($"-- Team '{myTeam.TeamName}' Players");
        foreach (SoccerPlayer player in myTeam)
        {
            Console.WriteLine(player);
        }

        Console.WriteLine("\n-- Player Search --");
        SoccerPlayer query = myTeam["player1"];
        Console.WriteLine(query);
    }
}
